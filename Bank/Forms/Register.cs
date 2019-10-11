using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Bank.Classes;
using static Bank.Methods.Methods;
using BCrypt.Net;

namespace Bank
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=../../Main.accdb;
            Persist Security Info=False;"))
            {
                connection.Open();

                string username = txtRegUser.Text.Trim();
                string pass = txtRegPwd.Text.Trim();
                string retypedPwd = txtRegRetypePwd.Text.Trim();
                string fName = txtRegFirstName.Text.Trim();
                string lName = txtRegLastName.Text.Trim();
                string amount = txtRegAmount.Text.Trim();





                //Calling the method that validates the user info
                var errorList = ValidateRegister(username, pass, retypedPwd, fName, lName, amount, connection);
                //If the returned array of errors contains no errors proceed with the registration
                if (errorList.Count == 0)
                {

                    RegisterUser(username, pass, fName, lName, Convert.ToDecimal(amount), connection);
                    MessageBox.Show("Registered successfully!","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    LoginForm frm = new LoginForm();
                    frm.Show();
                    this.Hide();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
                else
                {
                    //If there are errors they are written in label
                    lblRegError.Text = errorList[0];
                }
            }
        }

        //Prevents the user from entering anything else than letters in his First Name
        private void txtRegFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        //Prevents the user from entering anything else than letters in his Last Name
        private void txtRegLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        //Prevents the user from entering anything else than numbers and single floating point for the initial amount of money
        private void txtRegAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
