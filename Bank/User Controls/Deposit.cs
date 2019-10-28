using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Bank.Classes;

namespace Bank.Custom_Controls
{
    public partial class Deposit : UserControl
    {
        public User PassedUser { get; set; }



        public Deposit(User passedUser)
        {
            InitializeComponent();
            this.PassedUser = passedUser;
            this.btnDeposit.Enabled = false;
            this.btnDeposit.ForeColor = Color.Gray;
        }
       
        //Checks with regex if the inputted data is correct and enables the button
        private void txtDepositAmount_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtDepositAmount.Text, @"^(?:0|[1-9][0-9]*)(?:\.[0-9]{1,2})?$"))
            {
                txtDepositAmount.ForeColor = Color.Red;
                panelAmount.BackColor = Color.Red;
                btnDeposit.Enabled = false;
                this.btnDeposit.ForeColor = Color.Gray;

            }
            else
            {
                txtDepositAmount.ForeColor = Color.Lime;
                panelAmount.BackColor = Color.Lime;
                btnDeposit.Enabled = true;
                this.btnDeposit.ForeColor = Color.Lime;

            }
        }
        
        private void txtDepositAmount_Focus(object sender, EventArgs e)
        {
            
            if (txtDepositAmount.Text == "Amount")
            {
                txtDepositAmount.Text = "";
            }
        }
        private void txtDepositAmount_Leave(object sender, EventArgs e)
        {
            if (txtDepositAmount.Text == "")
            {
                txtDepositAmount.Text = "Amount";
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDepositAmount.Text, out decimal amount))
            {
                //Deposits upon success
                PassedUser.DebitCard.Deposit(amount);
                MessageBox.Show("Money deposited successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);              

            }
            else
            {
                MessageBox.Show("Value not correct!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

      
    }
}
