using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using static Bank.Methods.Methods;

namespace Bank.Classes
{
    public class Card
    {

        //Properties
        public string CardGUID { get; set; }
        public decimal Balance { get; set; }
        public int PIN { get; set; }

        //Constructors 

        public Card() { }
        public Card(string cardGUID, decimal balance, int pin)
        {
            this.CardGUID = cardGUID;
            this.Balance = balance;
            this.PIN = pin;
        }

        //Methods

        //Method that deposits money and then updated the DB
        public void Deposit(decimal money)
        {
            if (money > 0m)
            {
                this.Balance += money;

                //Updates the balance
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=../../Main.accdb;
            Persist Security Info=False;"))
                {
                    connection.Open();
                    OleDbCommand updateCommand = new OleDbCommand("UPDATE Cards SET Balance=@1 WHERE [GUID]=@2", connection);
                    updateCommand.Parameters.AddWithValue("@1", this.Balance);
                    updateCommand.Parameters.AddWithValue("@2", this.CardGUID);
                    updateCommand.ExecuteNonQuery();

                    //Logs every transaction
                    LogChanges(this.CardGUID, DateTime.Now.ToString(), "Deposit", money, connection);
                }
                
            }
        }

        //Method that withdraws money and then updates the DB
        public void Withdraw(decimal money)
        {
            if (money > 0m && this.Balance >= money)
            {
                this.Balance -= money;

                //Updates the balance
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=../../Main.accdb;
            Persist Security Info=False;"))
                {
                    connection.Open();
                    OleDbCommand updateCommand = new OleDbCommand("UPDATE Cards SET Balance=@1 WHERE [GUID]=@2", connection);
                    updateCommand.Parameters.AddWithValue("@1", this.Balance);
                    updateCommand.Parameters.AddWithValue("@2", this.CardGUID);
                    updateCommand.ExecuteNonQuery();

                    //Logs every transaction
                    LogChanges(this.CardGUID, DateTime.Now.ToString(), "Withdrawal", money, connection);
                }
            }
        }
    }
}
