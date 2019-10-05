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

namespace Bank
{
    using BCrypt = BCrypt.Net.BCrypt;
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            //Takes the entered values
            string usr = txt_username.Text.Trim();
            string pass = txt_pass.Text.Trim();

            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=Main.accdb;
            Persist Security Info=False;"))
            {
                connection.Open();

                if (Login(usr, pass, connection))
                {
                    
                    OleDbCommand commandUser;  // create command for User only
                    OleDbDataReader readerUser;  //Reader for User only            
                    commandUser = new OleDbCommand("Select * from Users where username=@1", connection);//Query for checking username and password
                    commandUser.Parameters.AddWithValue("@1", usr);
                    readerUser = commandUser.ExecuteReader();

                    if (readerUser != null)
                    {
                        //Creating new User object
                        User currentUser = new User();
                        //Reading from the user Reader
                        while (readerUser.Read())
                        {
                            currentUser = new User(readerUser["FirstName"].ToString(), readerUser["LastName"].ToString(), Convert.ToInt32(readerUser["CardID"]));
                        }

                        //Setting the DebitCard property with method that returns the Card from the DB that is with the associated ID
                        currentUser.DebitCard = SetCardToUser(currentUser, connection);


                        //Closing the current form and opens the main one while passing the current user
                        Main frm = new Main(currentUser);
                        frm.Show();
                        this.Hide();
                        frm.Closed += (s, args) => this.Close();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                    txt_username.Text = "";
                    txt_pass.Text = "";
                }
            }
        }  
    }
}


