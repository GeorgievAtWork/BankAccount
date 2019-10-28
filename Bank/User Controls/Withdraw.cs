using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Classes;
using System.Text.RegularExpressions;

namespace Bank.Custom_Controls
{
    public partial class Withdraw : UserControl
    {
        public User PassedUser { get; set; }



        public Withdraw(User passedUser)
        {
            InitializeComponent();
            this.PassedUser = passedUser;
            this.btnWithdraw.Enabled = false;
            this.btnWithdraw.ForeColor = Color.Gray;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWithdrawAmount.Text, out decimal amount))
            {
                //Checks if the wanted amount for withdrawal is more than the current balance
                if (amount <= PassedUser.DebitCard.Balance)
                {
                    //Withdraws upon success
                    PassedUser.DebitCard.Withdraw(amount);
                    MessageBox.Show("Money withdrawn successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
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
        //Checks with regex if the inputted data is correct and enables the button
        private void txtWithdrawAmount_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtWithdrawAmount.Text, @"^(?:0|[1-9][0-9]*)(?:\.[0-9]{1,2})?$"))
            {
                txtWithdrawAmount.ForeColor = Color.Red;
                panelAmount.BackColor = Color.Red;
                btnWithdraw.Enabled = false;
                this.btnWithdraw.ForeColor = Color.Gray;

            }
            else
            {
                txtWithdrawAmount.ForeColor = Color.Lime;
                panelAmount.BackColor = Color.Lime;
                btnWithdraw.Enabled = true;
                this.btnWithdraw.ForeColor = Color.Lime;

            }
        }

        private void txtWithdrawAmount_Focus(object sender, EventArgs e)
        {

            if (txtWithdrawAmount.Text == "Amount")
            {
                txtWithdrawAmount.Text = "";
            }
        }
        private void txtWithdrawAmount_Leave(object sender, EventArgs e)
        {
            if (txtWithdrawAmount.Text == "")
            {
                txtWithdrawAmount.Text = "Amount";
            }
        }
    }
}
