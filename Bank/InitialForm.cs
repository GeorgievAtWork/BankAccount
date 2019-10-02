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

namespace Bank
{
    public partial class InitialForm : Form
    {
        //Creating the connection variable
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=Main.accdb;
            Persist Security Info=False;");

        public InitialForm()
        {
            InitializeComponent();
            //Opening the connection to the DB
            connection.Open();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            //Takes the entered values
            string usr = txt_username.Text;
            string pass = txt_pass.Text;

            //Reader variable for the User only
            OleDbDataReader readerUser = Login(connection, usr, pass);
           
            
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

                //Closing the connection before opening next window
                connection.Close();
                //Opening main form application and passing the current user
                Main frm = new Main(currentUser);
                frm.Show();

            }


        }


        //Method that returns the card with the associated ID of the user
        public static Card SetCardToUser(User user, OleDbConnection connection)
        {
            OleDbCommand commanCard;  // create command for the Card only
            OleDbDataReader readerCard;  //Reader for the Card only

            //The query for finding the card in the DB
            commanCard = new OleDbCommand("Select * from Cards where ID=@1", connection);
            //Preventing SQL Injection attacks
            commanCard.Parameters.AddWithValue("@1", user.CardID);
            readerCard = commanCard.ExecuteReader();

            //Creating new Card Object
            Card currentCard = new Card();

            
            if (readerCard.HasRows)
            {
                //Reads from the DB
                while (readerCard.Read())
                {
                    
                    currentCard = new Card(Convert.ToInt32(readerCard["ID"]), Convert.ToDecimal(readerCard["Balance"]), Convert.ToInt32(readerCard["PIN"]));
                }

                return currentCard;
            }
            else { return null; }

            
           
        }

        //Method that tries to log in the user and returns reader with data from the DB according to username and password
        public static OleDbDataReader Login(OleDbConnection connection, string user, string password)
        {
            OleDbCommand commandUser;  // create command for User only
            OleDbDataReader readerUser;  //Reader for User only            
            commandUser = new OleDbCommand("Select * from Users where username=@1 AND password=@2", connection);//Query for checking username and password
            commandUser.Parameters.AddWithValue("@1", user);
            commandUser.Parameters.AddWithValue("@2", password);
            readerUser = commandUser.ExecuteReader();

           

            if (readerUser.HasRows)
            {
                return readerUser;
            }
            else
            {
                MessageBox.Show("Wrong username or password!");//If the reader has no rows in it displays Message box and returns null
                return null;
            }

        }

    }

}

