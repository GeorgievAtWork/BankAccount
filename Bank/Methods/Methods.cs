using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Classes;
using BCrypt.Net;

namespace Bank.Methods
{
    using BCrypt = BCrypt.Net.BCrypt;
    public class Methods
    {

        //Method that tries to log in the user and returns reader with data from the DB according to username and password
        public static bool Login(string user, string password, OleDbConnection connection)
        {

            OleDbCommand commandUser;  // create command for User only
            OleDbDataReader readerUser;  //Reader for User only            
            commandUser = new OleDbCommand("Select password from Users where Username=@1", connection);//Query for checking username and password
            commandUser.Parameters.AddWithValue("@1", user);
            readerUser = commandUser.ExecuteReader();
            bool isOkay = false;



            if (readerUser.HasRows)
            {
                
                while (readerUser.Read())
                {
                    //Checks if the stored hashed password is the same as its non-hashed version
                    isOkay = BCrypt.Verify(password, readerUser["password"].ToString());
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
            commandCard = new OleDbCommand("Select * from Cards where ID=@1", connection);
            //Preventing SQL Injection attacks
            commandCard.Parameters.AddWithValue("@1", user.CardID);
            readerCard = commandCard.ExecuteReader();

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
    }
}
