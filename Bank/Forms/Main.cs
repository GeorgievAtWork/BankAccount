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
using Bank.Custom_Controls;
using System.Runtime.InteropServices;


namespace Bank.Forms
{
    public partial class Main : Form
    {
        public User PassedUser { get; set; }

        //Consts for draggable flat form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main(User passedUser)
        {
            InitializeComponent();
            this.PassedUser = passedUser;
        }

        //Default loads the dashboard user control
        private void Main_Load(object sender, EventArgs e)
        {
            Control dashboard = new Dashboard(this.PassedUser);
            lblHead.Text = "Dashboard";
            panelUserControlHolder.Controls.Add(dashboard);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //On click loads different user controls in the panel, while also clearing the others and setting the current panel on the selected button
        private void btnViewHome_Click(object sender, EventArgs e)
        {
            Control dashboard = new Dashboard(this.PassedUser);
            lblHead.Text = "Dashboard";
            panelUserControlHolder.Controls.Clear();
            panelUserControlHolder.Controls.Add(dashboard);
            panelSide.Top = btnViewHome.Top;
        }

        private void btnViewDeposit_Click(object sender, EventArgs e)
        {
            Control deposit = new Deposit(this.PassedUser);
            panelUserControlHolder.Controls.Clear();
            panelUserControlHolder.Controls.Add(deposit);
            panelSide.Top = btnViewDeposit.Top;
            lblHead.Text = "Deposit";
        }

        private void btnViewWithdraw_Click(object sender, EventArgs e)
        {
            Control withdraw = new Withdraw(this.PassedUser);
            panelUserControlHolder.Controls.Clear();
            panelUserControlHolder.Controls.Add(withdraw);
            panelSide.Top = btnViewWithdraw.Top;
            lblHead.Text = "Withdraw";
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            Control logs = new Logs(this.PassedUser.DebitCard.CardGUID);
            panelUserControlHolder.Controls.Clear();
            panelUserControlHolder.Controls.Add(logs);
            panelSide.Top = btnViewLogs.Top;
            lblHead.Text = "Logs";
        }

        //Draggable
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {         
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();

        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
