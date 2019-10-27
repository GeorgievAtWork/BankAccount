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

namespace Bank.Custom_Controls
{
    public partial class Dashboard : UserControl
    {
        public User PassedUser { get; set; }

       
        
        public Dashboard(User passedUser)
        {
            InitializeComponent();
            this.PassedUser = passedUser;
           
        }
        //Takes the passed user and updates info
        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblName.Text = $"Hello, {this.PassedUser.FirstName}!";
            lblBalance.Text = PassedUser.DebitCard.Balance + " BGN";
        }

        //On text change checks the amount of money and changes the color of the text displaying the balance
        private void lblBalance_TextChanged(object sender, EventArgs e)
        {
            if (PassedUser.DebitCard.Balance == 0)
            {
                lblBalance.ForeColor = Color.Red;
            }
            else
            {
                lblBalance.ForeColor = Color.Lime;
            }
        }
    }
}
