using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Classes;
using Microsoft.VisualBasic;
using static Bank.Methods.Methods;
using Bank.Forms;


namespace Bank
{
    public partial class Main : Form
    {
        public User PassedUser { get; set; }

        public Main(User passedUser)
        {
            InitializeComponent();
            this.PassedUser = passedUser;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            //Changes the values for the labels
            lblName.Text = PassedUser.FirstName + " " + PassedUser.LastName;
            lblBalance.Text = PassedUser.DebitCard.Balance + " BGN";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Inputbox for the amount
            string value = Interaction.InputBox("Enter amount to deposit:", "Enter amount:");

            //Tries to parse the amount as usable decimal
            if (decimal.TryParse(value, out decimal amount))
            {
                //Deposits upon success
                PassedUser.DebitCard.Deposit(amount);
                MessageBox.Show("Money deposited successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Updates the label
                lblBalance.Text = PassedUser.DebitCard.Balance.ToString() + " BGN";
                if (PassedUser.DebitCard.Balance == 0m)
                {
                    lblBalance.ForeColor = Color.Red;
                }
                else
                {
                    lblBalance.ForeColor = Color.Lime;
                }
            }
            else
            {
                MessageBox.Show("Value not correct!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //Inputbox for the amount
            string value = Interaction.InputBox("Enter amount to withdraw:", "Enter amount:");

            //Tries to parse the amount as usable decimal
            if (decimal.TryParse(value, out decimal amount))
            {
                //Checks if the wanted amount for withdrawal is more than the current balance
                if (amount <= PassedUser.DebitCard.Balance)
                {
                    //Withdraws upon success
                    PassedUser.DebitCard.Withdraw(amount);
                    MessageBox.Show("Money withdrawn successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Updates the label
                    lblBalance.Text = PassedUser.DebitCard.Balance.ToString() + " BGN";
                    if (PassedUser.DebitCard.Balance == 0m)
                    {
                        lblBalance.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblBalance.ForeColor = Color.Lime;
                    }
                }
                else
                {
                    MessageBox.Show("Not enough balance!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Value not correct!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            //DataTable logs = GetLogs(PassedUser.CardGUID);
            LogsView logsView = new LogsView(PassedUser.DebitCard.CardGUID);
            logsView.Show();
            
        }
    }
}
