using Bank.Classes;
namespace Bank.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.btnViewWithdraw = new System.Windows.Forms.Button();
            this.btnViewDeposit = new System.Windows.Forms.Button();
            this.btnViewHome = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblHead = new System.Windows.Forms.Label();
            this.panelUserControlHolder = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSide);
            this.panel1.Controls.Add(this.btnViewLogs);
            this.panel1.Controls.Add(this.btnViewWithdraw);
            this.panel1.Controls.Add(this.btnViewDeposit);
            this.panel1.Controls.Add(this.btnViewHome);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 499);
            this.panel1.TabIndex = 3;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.Green;
            this.panelSide.Location = new System.Drawing.Point(0, 148);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 77);
            this.panelSide.TabIndex = 5;
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewLogs.FlatAppearance.BorderSize = 0;
            this.btnViewLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLogs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLogs.ForeColor = System.Drawing.Color.White;
            this.btnViewLogs.Image = global::Bank.Properties.Resources.logs;
            this.btnViewLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewLogs.Location = new System.Drawing.Point(12, 397);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(152, 77);
            this.btnViewLogs.TabIndex = 4;
            this.btnViewLogs.Text = "Logs";
            this.btnViewLogs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // btnViewWithdraw
            // 
            this.btnViewWithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewWithdraw.FlatAppearance.BorderSize = 0;
            this.btnViewWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewWithdraw.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnViewWithdraw.Image = global::Bank.Properties.Resources.Withdraw;
            this.btnViewWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewWithdraw.Location = new System.Drawing.Point(12, 314);
            this.btnViewWithdraw.Name = "btnViewWithdraw";
            this.btnViewWithdraw.Size = new System.Drawing.Size(152, 77);
            this.btnViewWithdraw.TabIndex = 3;
            this.btnViewWithdraw.Text = "Withdraw";
            this.btnViewWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewWithdraw.UseVisualStyleBackColor = true;
            this.btnViewWithdraw.Click += new System.EventHandler(this.btnViewWithdraw_Click);
            // 
            // btnViewDeposit
            // 
            this.btnViewDeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDeposit.FlatAppearance.BorderSize = 0;
            this.btnViewDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDeposit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeposit.ForeColor = System.Drawing.Color.White;
            this.btnViewDeposit.Image = global::Bank.Properties.Resources.Deposit;
            this.btnViewDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDeposit.Location = new System.Drawing.Point(12, 231);
            this.btnViewDeposit.Name = "btnViewDeposit";
            this.btnViewDeposit.Size = new System.Drawing.Size(152, 77);
            this.btnViewDeposit.TabIndex = 2;
            this.btnViewDeposit.Text = "Deposit";
            this.btnViewDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewDeposit.UseVisualStyleBackColor = true;
            this.btnViewDeposit.Click += new System.EventHandler(this.btnViewDeposit_Click);
            // 
            // btnViewHome
            // 
            this.btnViewHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewHome.FlatAppearance.BorderSize = 0;
            this.btnViewHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHome.ForeColor = System.Drawing.Color.White;
            this.btnViewHome.Image = global::Bank.Properties.Resources.home1;
            this.btnViewHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewHome.Location = new System.Drawing.Point(12, 148);
            this.btnViewHome.Name = "btnViewHome";
            this.btnViewHome.Size = new System.Drawing.Size(152, 77);
            this.btnViewHome.TabIndex = 1;
            this.btnViewHome.Text = "Dashboard";
            this.btnViewHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewHome.UseVisualStyleBackColor = true;
            this.btnViewHome.Click += new System.EventHandler(this.btnViewHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Green;
            this.panelLogo.BackgroundImage = global::Bank.Properties.Resources.Logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(167, 119);
            this.panelLogo.TabIndex = 0;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(212, 55);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(161, 32);
            this.lblHead.TabIndex = 4;
            this.lblHead.Text = "Dashboard";
            // 
            // panelUserControlHolder
            // 
            this.panelUserControlHolder.BackColor = System.Drawing.Color.Transparent;
            this.panelUserControlHolder.Location = new System.Drawing.Point(167, 119);
            this.panelUserControlHolder.MaximumSize = new System.Drawing.Size(731, 381);
            this.panelUserControlHolder.MinimumSize = new System.Drawing.Size(731, 381);
            this.panelUserControlHolder.Name = "panelUserControlHolder";
            this.panelUserControlHolder.Size = new System.Drawing.Size(731, 381);
            this.panelUserControlHolder.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 30);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(706, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(899, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelUserControlHolder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(899, 499);
            this.MinimumSize = new System.Drawing.Size(899, 499);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Button btnViewWithdraw;
        private System.Windows.Forms.Button btnViewDeposit;
        private System.Windows.Forms.Button btnViewHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Panel panelUserControlHolder;
        private System.Windows.Forms.Panel panel2;
        //private Custom_Controls.Dashboard dashboard1;
    }
}