using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Bank.Classes;
using static Bank.Methods.Methods;
using BCrypt.Net;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;


namespace Bank
{
    public partial class Register : Form
    {
        //Consts for draggable flat form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Register()
        {
            InitializeComponent();

            //Disables the register button

            btnRegister.Enabled = false;
            btnRegister.ForeColor = Color.Gray;

            //Changes the Tag property of each control to false
            txtRegAmount.Tag = false;
            txtRegFirstName.Tag = false;
            txtRegLastName.Tag = false;
            txtRegPwd.Tag = false;
            txtRegRetypePwd.Tag = false;
            txtRegUser.Tag = false;
        }

        //Events

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=../../Main.accdb;
            Persist Security Info=False;"))
            {
                //Opens DB connection
                connection.Open();

                var freeUsername = ValidateUsername(txtRegUser, this.panelUser, connection);
                //If the returned value from the function is true register the user with the texts from the textboxes
                if (freeUsername)
                {
                    string username = txtRegUser.Text.Trim();
                    string pass = txtRegPwd.Text.Trim();
                    string retypedPwd = txtRegRetypePwd.Text.Trim();
                    string fName = txtRegFirstName.Text.Trim();
                    string lName = txtRegLastName.Text.Trim();
                    string amount = txtRegAmount.Text.Trim();

                    int pin = RegisterUser(username, pass, fName, lName, Convert.ToDecimal(amount), connection);
                    MessageBox.Show($"Registered successfully! Your PIN is: {pin}, please keep it safe!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }      

        //Calls the validation method for each control onTextChange event
        private void txtRegUser_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError((TextBox)sender, null);
            txt_Validation(sender, this.panelUser);
        }

        private void txtRegPwd_TextChanged(object sender, EventArgs e)
        {

            txt_Validation(sender, this.panelPwd);
            errorProvider.SetError(txtRegRetypePwd, "Passwords does not match!");
            txt_Validation(txtRegRetypePwd, this.panelRetypePwd);
        }

        private void txtRegRetypePwd_TextChanged(object sender, EventArgs e)
        {
            txt_Validation(sender, this.panelRetypePwd);
        }

        private void txtRegFirstName_TextChanged(object sender, EventArgs e)
        {
            txt_Validation(sender, this.panelFirstName);
        }

        private void txtRegLastName_TextChanged(object sender, EventArgs e)
        {
            txt_Validation(sender, this.panelLastName);
        }

        private void txtRegAmount_TextChanged(object sender, EventArgs e)
        {
            txt_Validation(sender, this.panelAmount);
        }

        //Methods

        //Validation method that checks for empty values and then call ValidationRouter for current textbox
        public void txt_Validation(object sender, object panel)
        {
            btnRegister.Enabled = false;
            this.btnRegister.ForeColor = Color.Gray;

            TextBox txt = (TextBox)sender;
            Panel currentPanel = (Panel)panel;
            bool isOk = false;
            if (txt.Text.Length == 0)
            {
                //Changes the color and the Tag property of the current textbox
                txt.ForeColor = Color.Red;
                currentPanel.BackColor = Color.Red;
                txt.Tag = false;
            }
            else
            {
                //Excludes the Username textbox
                if (txt.Name != "txtRegUser")
                {
                    //Calls the ValidationRouter
                    isOk = ValidationRouter(txt);
                }
                else
                {
                    isOk = true;
                }
            }

            if (isOk)
            {
                //If everything is okay turns the box in to green, the Tag property to true
                //and attempts to enable the registration button
                txt.ForeColor = Color.Lime;
                currentPanel.BackColor = Color.Lime;
                if (txt.Text != "txtRegUser") { txt.Tag = true; }
                EnableRegister();
            }
            else
            {
                //If the ValidationRouter returned false, then turns the textbox red
                txt.ForeColor = Color.Red;
                currentPanel.BackColor = Color.Red;
                txt.Tag = false;
            }

        }

        //Method that calls the appropriate validation based on the name of the control
        public bool ValidationRouter(TextBox tb)
        {
            if (tb.Name == "txtRegPwd")
            {
                return ValidatePassword(tb);
            }
            else if (tb.Name == "txtRegRetypePwd")
            {
                return ValidatePasswordMatch(tb);
            }
            else if (tb.Name == "txtRegAmount")
            {
                return ValidateAmount(tb);
            }
            else
            {
                return ValidateNames(tb);
            }
        }

        //Validation for username that checks the DB for the username
        public bool ValidateUsername(TextBox tb, Panel panel, OleDbConnection connection)
        {
            //Query for checking if username exists
            OleDbCommand commandUserName = new OleDbCommand("Select Username from Users where Username=@1", connection);
            commandUserName.Parameters.AddWithValue("@1", tb.Text);
            OleDbDataReader readerUser = commandUserName.ExecuteReader();

            //If the query returned any rows add errorProvider and changes the color
            if (readerUser.HasRows)
            {
                errorProvider.SetError(tb, "Username already in use!");
                tb.ForeColor = Color.Red;
                panel.BackColor = Color.Red;
                tb.Tag = false;
                EnableRegister();
                return false;
            }
            //Clears error
            errorProvider.SetError(tb, null);
            tb.Tag = true;            
            return true;
        }

        //Validation method for password
        public bool ValidatePassword(TextBox tb)
        {
            //Checking for password strength using regular expressions
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isPwdOk = hasNumber.IsMatch(tb.Text) && hasUpperChar.IsMatch(tb.Text) && hasMinimum8Chars.IsMatch(tb.Text);

            if (!isPwdOk)
            {
                //If the password doesn't match the regular expression, adds errorProvider error next to the textbox
                errorProvider.SetError(tb, "Password must be atleast 8 characters\nwith atleast 1 capital letter and 1 number");
                return false;
            }
            //Clears the error if everything is okay
            errorProvider.SetError(tb, null);
            return true;

        }

        //Validation for the retyped password
        public bool ValidatePasswordMatch(TextBox tb)
        {
            if (tb.Text != txtRegPwd.Text)
            {
                //Sets errorProvider
                errorProvider.SetError(tb, "Passwords does not match!");
                return false;
            }
            //Clears errorProvider
            errorProvider.SetError(tb, null);
            return true;
        }

        //Validation for the names field
        public bool ValidateNames(TextBox tb)
        {
            //Regular expression for text only
            if (!Regex.IsMatch(tb.Text, @"^[a-zA-Z]+$"))
            {
                //Sets errorProvider
                errorProvider.SetError(tb, "Only letters allowed!");
                return false;
            }
            //Clears errorProvider
            errorProvider.SetError(tb, null);
            return true;

        }

       

        //Validation for the money amount with regular expression to only accept numbers
        //and decimals with 2 decimal places after floating point
        public bool ValidateAmount(TextBox tb)
        {
            if (!Regex.IsMatch(tb.Text, @"^(?:0|[1-9][0-9]*)(?:\.[0-9]{1,2})?$"))
            {
                //Sets error
                errorProvider.SetError(tb, "Amount must be integer or decimal with maximum 2 decimal places\n after floating point");
                return false;
            }
            //Clears error
            errorProvider.SetError(tb, null);
            return true;
        }

        //Enables the register Button
        private void EnableRegister()
        {
            this.btnRegister.Enabled = ((bool)txtRegAmount.Tag && (bool)txtRegUser.Tag && (bool)txtRegPwd.Tag && (bool)txtRegRetypePwd.Tag && (bool)txtRegFirstName.Tag && (bool)txtRegLastName.Tag);
            if (btnRegister.Enabled == true)
            {
                btnRegister.ForeColor = Color.Lime;
                
            }
            else
            {
                btnRegister.ForeColor = Color.Gray;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Draggable 
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Event handlers for placeholder text
        private void txtRegUser_Focus(object sender, EventArgs e)
        {
            txtRegUser.ForeColor = Color.White;
            panelUser.BackColor = Color.White;
            if (txtRegUser.Text == "Username")
            {
                txtRegUser.Text = "";
            }
        }

        private void txtRegUser_Leave(object sender, EventArgs e)
        {
            if (txtRegUser.Text == "")
            {
                txtRegUser.Text = "Username";
            }
        }

        private void txtRegPwd_Focus(object sender, EventArgs e)
        {           
            txtRegPwd.ForeColor = Color.White;
            panelPwd.BackColor = Color.White;
            if (txtRegPwd.Text == "Password")
            {
                txtRegPwd.Text = "";
                txtRegPwd.PasswordChar = '*';
            }
        }
        private void txtRegPwd_Leave(object sender, EventArgs e)
        {
            if (txtRegPwd.Text == "")
            {
                txtRegPwd.Text = "Password";
                txtRegPwd.PasswordChar = '\0';
            }
        }

        private void txtRegRetypePwd_Focus(object sender, EventArgs e)
        {
            txtRegRetypePwd.ForeColor = Color.White;
            panelRetypePwd.BackColor = Color.White;
            if (txtRegRetypePwd.Text == "Retype Password")
            {
                txtRegRetypePwd.Text = "";
                txtRegRetypePwd.PasswordChar = '*';
            }
        }
        private void txtRegRetypePwd_Leave(object sender, EventArgs e)
        {
            if (txtRegRetypePwd.Text == "")
            {
                txtRegRetypePwd.Text = "Retype Password";
                txtRegRetypePwd.PasswordChar = '\0';
            }
        }

        private void txtRegFirstName_Focus(object sender, EventArgs e)
        {
            txtRegFirstName.ForeColor = Color.White;
            panelFirstName.BackColor = Color.White;
            if (txtRegFirstName.Text == "First Name")
            {
                txtRegFirstName.Text = "";
            }
        }
        private void txtRegFirstName_Leave(object sender, EventArgs e)
        {
            if (txtRegFirstName.Text == "")
            {
                txtRegFirstName.Text = "First Name";
            }
        }

        private void txtRegLastName_Focus(object sender, EventArgs e)
        {
            txtRegLastName.ForeColor = Color.White;
            panelLastName.BackColor = Color.White;
            if (txtRegLastName.Text == "Last Name")
            {
                txtRegLastName.Text = "";
            }
        }
        private void txtRegLastName_Leave(object sender, EventArgs e)
        {
            if (txtRegLastName.Text == "")
            {
                txtRegLastName.Text = "Last Name";
            }
        }

        private void txtRegAmount_Focus(object sender, EventArgs e)
        {
            txtRegAmount.ForeColor = Color.White;
            panelAmount.BackColor = Color.White;
            if (txtRegAmount.Text == "Amount")
            {
                txtRegAmount.Text = "";
            }
        }
        private void txtRegAmount_Leave(object sender, EventArgs e)
        {
            if (txtRegAmount.Text == "")
            {
                txtRegAmount.Text = "Amount";
            }
        }




    }
}
