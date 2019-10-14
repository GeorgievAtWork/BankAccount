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


namespace Bank
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            //Disables the register button
            btnRegister.Enabled = false;

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

                var freeUsername = ValidateUsername(txtRegUser, connection);
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
        //Back button closes the form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Calls the validation method for each control onTextChange event
        private void txtRegUser_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError((TextBox)sender, null);
            txt_Validation(sender);
        }

        private void txtRegPwd_TextChanged(object sender, EventArgs e)
        {

            txt_Validation(sender);
            errorProvider.SetError(txtRegRetypePwd, "Passwords does not match!");
            txt_Validation(txtRegRetypePwd);
        }

        private void txtRegRetypePwd_TextChanged(object sender, EventArgs e)
        {
            txt_Validation(sender);
        }

        private void txtRegFirstName_TextChanged(object sender, EventArgs e)
        {
            txt_Validation(sender);
        }

        private void txtRegLastName_TextChanged(object sender, EventArgs e)
        {
            txt_Validation(sender);
        }

        private void txtRegAmount_TextChanged(object sender, EventArgs e)
        {
            txt_Validation(sender);
        }

        //Methods

        //Validation method that checks for empty values and then call ValidationRouter for current textbox
        public void txt_Validation(object sender)
        {
            btnRegister.Enabled = false;

            TextBox txt = (TextBox)sender;
            bool isOk = false;
            if (txt.Text.Length == 0)
            {
                //Changes the color and the Tag property of the current textbox
                txt.BackColor = Color.Red;
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
                txt.BackColor = Color.Lime;
                txt.Tag = true;
                EnableRegister();
            }
            else
            {
                //If the ValidationRouter returned false, then turns the textbox red
                txt.BackColor = Color.Red;
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

        //Validation for username that checks the DB for the username
        public bool ValidateUsername(TextBox tb, OleDbConnection connection)
        {
            //Query for checking if username exists
            OleDbCommand commandUserName = new OleDbCommand("Select Username from Users where Username=@1", connection);
            commandUserName.Parameters.AddWithValue("@1", tb.Text);
            OleDbDataReader readerUser = commandUserName.ExecuteReader();

            //If the query returned any rows add errorProvider and changes the color
            if (readerUser.HasRows)
            {
                errorProvider.SetError(tb, "Username already in use!");
                tb.BackColor = Color.Red;
                return false;
            }
            //Clears error
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
        }
    }
}
