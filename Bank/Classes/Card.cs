using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Bank.Classes
{
    public class Card
    {
      

        public int CardID { get; set; }
        public decimal Balance { get; set; }
        public int PIN { get; set; }

        public Card() { }
        public Card(int cardID, decimal balance, int pin)
        {
            this.CardID = cardID;
            this.Balance = balance;
            this.PIN = pin;
        }

        public void Deposit(decimal money, OleDbConnection conn) {
            if (money > 0m)
            {
                this.Balance += money;


                OleDbDataAdapter da = new OleDbDataAdapter();
                string query = "UPDATE Cards SET Balance=@1 WHERE ID=@2";
                var accessUpdateCommand = new OleDbCommand(query, conn);
                accessUpdateCommand.Parameters.AddWithValue("@1", this.Balance);
                accessUpdateCommand.Parameters.AddWithValue("@2", this.CardID); 
                da.UpdateCommand = accessUpdateCommand;
                da.UpdateCommand.ExecuteNonQuery();
            }
        }
        public void Withdraw(decimal money, OleDbConnection conn)
        {
            if (money > 0m)
            {
                this.Balance -= money;


                OleDbDataAdapter da = new OleDbDataAdapter();
                string query = "UPDATE Cards SET Balance=@1 WHERE ID=@2";
                var accessUpdateCommand = new OleDbCommand(query, conn);
                accessUpdateCommand.Parameters.AddWithValue("@1", this.Balance);
                accessUpdateCommand.Parameters.AddWithValue("@2", this.CardID);
                da.UpdateCommand = accessUpdateCommand;
                da.UpdateCommand.ExecuteNonQuery();
            }
        }
    }
}
