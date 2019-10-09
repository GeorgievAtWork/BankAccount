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

namespace Bank
{
    using BCrypt = BCrypt.Net.BCrypt;
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
                            MessageBox.Show("Wrong PIN!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            txtUser.Text = "";
                            txtPwd.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("PIN format not correct!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Text = "";
                        txtPwd.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPwd.Text = "";
                }
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Register frm = new Register();
            frm.Show();
            this.Hide();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }


    }
}


