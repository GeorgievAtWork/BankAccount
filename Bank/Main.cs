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
            label1.Text = PassedUser.FirstName;
            label2.Text = PassedUser.LastName;
            label3.Text = PassedUser.DebitCard.Balance.ToString();
        }
    }
}
