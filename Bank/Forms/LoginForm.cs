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
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using Bank.Forms;


namespace Bank
{
    using BCrypt = BCrypt.Net.BCrypt;
    public partial class LoginForm : Form
    {
        //Consts for draggable flat form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public LoginForm()
        {
            InitializeComponent();
            this.Select();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Takes the entered values
            string user = txtUser.Text.Trim();
            string pass = txtPwd.Text.Trim();

            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=../../Main.accdb;
            Persist Security Info=False;"))
            {
                connection.Open();

                if (CheckLogin(user, pass, connection))
                {

                    OleDbCommand commandUser;  // create command for User only
                    OleDbDataReader readerUser;  //Reader for User only            
                    commandUser = new OleDbCommand("Select * from Users where username=@1", connection);//Query for checking username and password
                    commandUser.Parameters.AddWithValue("@1", user);
                    readerUser = commandUser.ExecuteReader();


                    //Creating new User object
                    User currentUser = new User();
                    //Reading from the user Reader
                    while (readerUser.Read())
                    {
                        currentUser = new User(readerUser["FirstName"].ToString(), readerUser["LastName"].ToString(), readerUser["cardGUID"].ToString());
                    }


                    //Setting the DebitCard property with method that returns the Card from the DB that is with the associated ID
                    currentUser.DebitCard = SetCardToUser(currentUser, connection);
                    var pin = Interaction.InputBox("Enter your PIN for additional security", "PIN prompt").ToString();
                    if (int.TryParse(pin, out int parsedPIN))
                    {
                        //Checks for PIN for additional security
                        if (CheckPIN(parsedPIN, currentUser.DebitCard.PIN))
                        {
                            //Closing the current form and opens the main one while passing the current user
                            Main frm = new Main(currentUser);
                            frm.Show();
                            this.Hide();
                            frm.Closed += (s, args) => this.Close();
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong PIN!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUser.Text = "Username";
                            txtPwd.Text = "Password";
                            txtPwd.PasswordChar = '\0';
                        }
                    }
                    else
                    {
                        MessageBox.Show("PIN format not correct!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Text = "Username";
                        txtPwd.Text = "Password";
                        txtPwd.PasswordChar = '\0';
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "Username";
                    txtPwd.Text = "Password";
                    txtPwd.PasswordChar = '\0';
                    txtUser.ForeColor = Color.Red;
                    txtPwd.ForeColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    panel3.BackColor = Color.Red;
                    pictureBox2.BackgroundImage = new Bitmap(Bank.Properties.Resources.user_red);
                    pictureBox3.BackgroundImage = new Bitmap(Bank.Properties.Resources.lock_red);

                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Focus(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = new Bitmap(Bank.Properties.Resources.userwhite);
            txtUser.ForeColor = Color.White;
            panel2.BackColor = Color.White;
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
            }
        }       

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
            }
        }

        private void txtPwd_Focus(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = new Bitmap(Bank.Properties.Resources.lockwhite);
            txtPwd.ForeColor = Color.White;
            panel3.BackColor = Color.White;
            if (txtPwd.Text == "Password")
            {
                txtPwd.Text = "";
                txtPwd.PasswordChar = '*';
            }
        }

        private void txtPwd_Leave(object sender, EventArgs e)
        {
            if (txtPwd.Text == "")
            {
                txtPwd.Text = "Password";
                txtPwd.PasswordChar = '\0';
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

       
    }
}


