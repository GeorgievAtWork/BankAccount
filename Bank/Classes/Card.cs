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


        public string CardGUID { get; set; }
        public decimal Balance { get; set; }
        public int PIN { get; set; }

        public Card() { }
        public Card(string cardGUID, decimal balance, int pin)
        {
            this.CardGUID = cardGUID;
            this.Balance = balance;
            this.PIN = pin;
        }

        public void Deposit(decimal money, OleDbConnection conn)
        {
            if (money > 0m)
            {
                this.Balance += money;


                OleDbDataAdapter da = new OleDbDataAdapter();
                string query = "UPDATE Cards SET Balance=@1 WHERE ID=@2";
                var accessUpdateCommand = new OleDbCommand(query, conn);
                accessUpdateCommand.Parameters.AddWithValue("@1", this.Balance);
                accessUpdateCommand.Parameters.AddWithValue("@2", this.CardGUID);
                da.UpdateCommand = accessUpdateCommand;
                da.UpdateCommand.ExecuteNonQuery();
            }
        }
        public void Withdraw(decimal money, OleDbConnection conn)
        {
            if (money > 0m && this.Balance > money)
            {
                this.Balance -= money;


                OleDbDataAdapter da = new OleDbDataAdapter();
                string query = "UPDATE Cards SET Balance=@1 WHERE ID=@2";
                var accessUpdateCommand = new OleDbCommand(query, conn);
                accessUpdateCommand.Parameters.AddWithValue("@1", this.Balance);
                accessUpdateCommand.Parameters.AddWithValue("@2", this.CardGUID);
                da.UpdateCommand = accessUpdateCommand;
                da.UpdateCommand.ExecuteNonQuery();
            }
        }
    }
}
