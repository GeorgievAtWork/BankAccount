using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Classes;
using System.Text.RegularExpressions;
using BCrypt.Net;
using System.Data;
using System.Windows.Forms;

namespace Bank.Methods
{
    using BCrypt = BCrypt.Net.BCrypt;
    public class Methods
    {
        
        //Method that checks the PIN for additional security
        public static bool CheckPIN(int enteredPIN, int dbPIN)
        {
            return (enteredPIN == dbPIN);
        }

        //Method that logs any deposit/withdrawal from card
        public static void LogChanges(string cardGUID, string date, string type, decimal amount, OleDbConnection conn)
        {
            OleDbCommand commandLog = new OleDbCommand("INSERT INTO Logs (CardGUID, [Date], Type, Amount) values (@1,@2,@3,@4)", conn);
            commandLog.Parameters.AddWithValue("@1", cardGUID);
            commandLog.Parameters.AddWithValue("@2", date);
            commandLog.Parameters.AddWithValue("@3", type);
            commandLog.Parameters.AddWithValue("@4", amount);
            commandLog.ExecuteNonQuery();

        }

        //Method that validates the information that the user inputted to the registration form and returns error as string
        public static string ValidateRegister(string user, string password, string retypedPwd, string fName, string lName, string amount, OleDbConnection connection)
        {
            string error = "";

            //Checks for blank fields
            if (user.Length == 0 || password.Length == 0 || retypedPwd.Length == 0 || fName.Length == 0 || lName.Length == 0 || amount.Length == 0)
            {
                error = "Please input all fields!";
                return error;
            }

            //Query for checking if username exists
            OleDbCommand commandRegister = new OleDbCommand("Select Username from Users where Username=@1", connection);
            commandRegister.Parameters.AddWithValue("@1", user);
            OleDbDataReader readerRegister = commandRegister.ExecuteReader();

            //The check
            if (readerRegister.HasRows)
            {
                error = "This username is already used!";
                return error;
            }

            //Checks if password is retyped correctly
            if (retypedPwd != password)
            {
                error = "The passwords don't match!";
                return error;
            }


            //Checking for password strength using regular expressions
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");

            var isPwdOk = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password);

            if (isPwdOk == false)
            {
                error = "Password doesn't meet the requirements!";
            }

            return error;

        }
        //Method that registers the user and its debit card
        public static int RegisterUser(string user, string password, string fName, string lName, decimal amount, OleDbConnection connection)
        {
            //Creating GUID for the card unique ID
            var newGuid = Guid.NewGuid();
            //Hasing the password using BCrypt
            string hashedPwd = BCrypt.HashPassword(password, BCrypt.GenerateSalt());

            //Query for inserting the new user in the DB
            OleDbCommand CommandRegisterUser = new OleDbCommand("INSERT into Users (Username,pass,FirstName,LastName,CardGUID) values (@1,@2,@3,@4,@5)", connection);
            CommandRegisterUser.Parameters.AddWithValue("@1", user);
            CommandRegisterUser.Parameters.AddWithValue("@2", hashedPwd);
            CommandRegisterUser.Parameters.AddWithValue("@3", fName);
            CommandRegisterUser.Parameters.AddWithValue("@4", lName);
            CommandRegisterUser.Parameters.AddWithValue("@5", newGuid);
            CommandRegisterUser.ExecuteNonQuery();

            //Used in creating PIN
            Random rand = new Random();
            int pin = rand.Next(1000, 9999);
            //Query for creating the new Debit card for the newly created user
            OleDbCommand CommandRegisterCard = new OleDbCommand("INSERT INTO Cards ([GUID],Balance,PIN) VALUES (@guid,@amount,@pin)", connection);
            CommandRegisterCard.Parameters.AddWithValue("@guid", newGuid);
            CommandRegisterCard.Parameters.AddWithValue("@amount", amount);
            CommandRegisterCard.Parameters.AddWithValue("@pin", pin);
            CommandRegisterCard.ExecuteNonQuery();

            return pin;


        }

        //Method that tries to log in the user and returns reader with data from the DB according to username and password
        public static bool CheckLogin(string user, string password, OleDbConnection connection)
        {

            OleDbCommand commandUser;  // create command for User only
            OleDbDataReader readerUser;  //Reader for User only            
            commandUser = new OleDbCommand("Select pass from Users where Username=@user", connection);//Query for checking username and password
            commandUser.Parameters.AddWithValue("@user", user);
            readerUser = commandUser.ExecuteReader();
            bool isOkay = false;



            if (readerUser.HasRows)
            {

                while (readerUser.Read())
                {
                    //Checks if the stored hashed password is the same as its non-hashed version
                    isOkay = BCrypt.Verify(password, readerUser["pass"].ToString());
                }

                return (isOkay == true);

            }
            else
            {
                return false;
            }

        }

        //Method that returns the card with the associated ID of the user
        public static Card SetCardToUser(User user, OleDbConnection connection)
        {
            OleDbCommand commandCard;  // create command for the Card only
            OleDbDataReader readerCard;  //Reader for the Card only

            //The query for finding the card in the DB
            commandCard = new OleDbCommand("Select * from Cards where GUID=@1", connection);
            //Preventing SQL Injection attacks
            commandCard.Parameters.AddWithValue("@1", user.CardGUID);
            readerCard = commandCard.ExecuteReader();

            //Creating new Card Object
            Card currentCard = new Card();


            if (readerCard.HasRows)
            {
                //Reads from the DB
                while (readerCard.Read())
                {

                    currentCard = new Card(user.CardGUID, Convert.ToDecimal(readerCard["Balance"]), Convert.ToInt32(readerCard["PIN"]));
                }

                return currentCard;
            }
            else { return null; }



        }
    }
}
