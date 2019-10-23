namespace Bank
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lblRegWelcome = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.txtRegUser = new System.Windows.Forms.TextBox();
            this.panelPwd = new System.Windows.Forms.Panel();
            this.txtRegPwd = new System.Windows.Forms.TextBox();
            this.panelRetypePwd = new System.Windows.Forms.Panel();
            this.txtRegRetypePwd = new System.Windows.Forms.TextBox();
            this.panelFirstName = new System.Windows.Forms.Panel();
            this.txtRegFirstName = new System.Windows.Forms.TextBox();
            this.panelLastName = new System.Windows.Forms.Panel();
            this.txtRegLastName = new System.Windows.Forms.TextBox();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.txtRegAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegWelcome
            // 
            this.lblRegWelcome.AutoSize = true;
            this.lblRegWelcome.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegWelcome.Location = new System.Drawing.Point(137, 173);
            this.lblRegWelcome.MaximumSize = new System.Drawing.Size(500, 300);
            this.lblRegWelcome.Name = "lblRegWelcome";
            this.lblRegWelcome.Size = new System.Drawing.Size(158, 29);
            this.lblRegWelcome.TabIndex = 0;
            this.lblRegWelcome.Text = "Registration";
            this.lblRegWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(190)))), ((int)(((byte)(138)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(147, 506);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(139, 46);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Bank.Properties.Resources.gradient;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 157);
            this.panel1.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Bank.Properties.Resources.close_white;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(393, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Bank.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Black;
            this.panelUser.ForeColor = System.Drawing.Color.Maroon;
            this.panelUser.Location = new System.Drawing.Point(116, 250);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(200, 1);
            this.panelUser.TabIndex = 18;
            // 
            // txtRegUser
            // 
            this.txtRegUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRegUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUser.Location = new System.Drawing.Point(116, 224);
            this.txtRegUser.Name = "txtRegUser";
            this.txtRegUser.Size = new System.Drawing.Size(200, 20);
            this.txtRegUser.TabIndex = 17;
            this.txtRegUser.Text = "Username";
            this.txtRegUser.TextChanged += new System.EventHandler(this.txtRegUser_TextChanged);
            this.txtRegUser.Enter += new System.EventHandler(this.txtRegUser_Focus);
            this.txtRegUser.Leave += new System.EventHandler(this.txtRegUser_Leave);
            // 
            // panelPwd
            // 
            this.panelPwd.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelPwd.ForeColor = System.Drawing.Color.Maroon;
            this.panelPwd.Location = new System.Drawing.Point(116, 292);
            this.panelPwd.Name = "panelPwd";
            this.panelPwd.Size = new System.Drawing.Size(200, 1);
            this.panelPwd.TabIndex = 20;
            // 
            // txtRegPwd
            // 
            this.txtRegPwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRegPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPwd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPwd.Location = new System.Drawing.Point(116, 266);
            this.txtRegPwd.Name = "txtRegPwd";
            this.txtRegPwd.Size = new System.Drawing.Size(200, 20);
            this.txtRegPwd.TabIndex = 19;
            this.txtRegPwd.Text = "Password";
            this.txtRegPwd.TextChanged += new System.EventHandler(this.txtRegPwd_TextChanged);
            this.txtRegPwd.Enter += new System.EventHandler(this.txtRegPwd_Focus);
            this.txtRegPwd.Leave += new System.EventHandler(this.txtRegPwd_Leave);
            // 
            // panelRetypePwd
            // 
            this.panelRetypePwd.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelRetypePwd.ForeColor = System.Drawing.Color.Maroon;
            this.panelRetypePwd.Location = new System.Drawing.Point(116, 337);
            this.panelRetypePwd.Name = "panelRetypePwd";
            this.panelRetypePwd.Size = new System.Drawing.Size(200, 1);
            this.panelRetypePwd.TabIndex = 22;
            // 
            // txtRegRetypePwd
            // 
            this.txtRegRetypePwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRegRetypePwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegRetypePwd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegRetypePwd.Location = new System.Drawing.Point(116, 311);
            this.txtRegRetypePwd.Name = "txtRegRetypePwd";
            this.txtRegRetypePwd.Size = new System.Drawing.Size(200, 20);
            this.txtRegRetypePwd.TabIndex = 21;
            this.txtRegRetypePwd.Text = "Retype Password";
            this.txtRegRetypePwd.TextChanged += new System.EventHandler(this.txtRegRetypePwd_TextChanged);
            this.txtRegRetypePwd.Enter += new System.EventHandler(this.txtRegRetypePwd_Focus);
            this.txtRegRetypePwd.Leave += new System.EventHandler(this.txtRegRetypePwd_Leave);
            // 
            // panelFirstName
            // 
            this.panelFirstName.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelFirstName.ForeColor = System.Drawing.Color.Maroon;
            this.panelFirstName.Location = new System.Drawing.Point(116, 381);
            this.panelFirstName.Name = "panelFirstName";
            this.panelFirstName.Size = new System.Drawing.Size(200, 1);
            this.panelFirstName.TabIndex = 24;
            // 
            // txtRegFirstName
            // 
            this.txtRegFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRegFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegFirstName.Location = new System.Drawing.Point(116, 355);
            this.txtRegFirstName.Name = "txtRegFirstName";
            this.txtRegFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtRegFirstName.TabIndex = 23;
            this.txtRegFirstName.Text = "First Name";
            this.txtRegFirstName.TextChanged += new System.EventHandler(this.txtRegFirstName_TextChanged);
            this.txtRegFirstName.Enter += new System.EventHandler(this.txtRegFirstName_Focus);
            this.txtRegFirstName.Leave += new System.EventHandler(this.txtRegFirstName_Leave);
            // 
            // panelLastName
            // 
            this.panelLastName.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelLastName.ForeColor = System.Drawing.Color.Maroon;
            this.panelLastName.Location = new System.Drawing.Point(116, 424);
            this.panelLastName.Name = "panelLastName";
            this.panelLastName.Size = new System.Drawing.Size(200, 1);
            this.panelLastName.TabIndex = 26;
            // 
            // txtRegLastName
            // 
            this.txtRegLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRegLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegLastName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegLastName.Location = new System.Drawing.Point(116, 398);
            this.txtRegLastName.Name = "txtRegLastName";
            this.txtRegLastName.Size = new System.Drawing.Size(200, 20);
            this.txtRegLastName.TabIndex = 25;
            this.txtRegLastName.Text = "Last Name";
            this.txtRegLastName.TextChanged += new System.EventHandler(this.txtRegLastName_TextChanged);
            this.txtRegLastName.Enter += new System.EventHandler(this.txtRegLastName_Focus);
            this.txtRegLastName.Leave += new System.EventHandler(this.txtRegLastName_Leave);
            // 
            // panelAmount
            // 
            this.panelAmount.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelAmount.ForeColor = System.Drawing.Color.Maroon;
            this.panelAmount.Location = new System.Drawing.Point(116, 471);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(200, 1);
            this.panelAmount.TabIndex = 28;
            // 
            // txtRegAmount
            // 
            this.txtRegAmount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRegAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegAmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegAmount.Location = new System.Drawing.Point(116, 445);
            this.txtRegAmount.Name = "txtRegAmount";
            this.txtRegAmount.Size = new System.Drawing.Size(200, 20);
            this.txtRegAmount.TabIndex = 27;
            this.txtRegAmount.Text = "Amount";
            this.txtRegAmount.TextChanged += new System.EventHandler(this.txtRegAmount_TextChanged);
            this.txtRegAmount.Enter += new System.EventHandler(this.txtRegAmount_Focus);
            this.txtRegAmount.Leave += new System.EventHandler(this.txtRegAmount_Leave);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 597);
            this.Controls.Add(this.panelAmount);
            this.Controls.Add(this.txtRegAmount);
            this.Controls.Add(this.panelLastName);
            this.Controls.Add(this.txtRegLastName);
            this.Controls.Add(this.panelFirstName);
            this.Controls.Add(this.txtRegFirstName);
            this.Controls.Add(this.panelRetypePwd);
            this.Controls.Add(this.txtRegRetypePwd);
            this.Controls.Add(this.panelPwd);
            this.Controls.Add(this.txtRegPwd);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.txtRegUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRegWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 597);
            this.MinimumSize = new System.Drawing.Size(432, 597);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegWelcome;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox txtRegUser;
        private System.Windows.Forms.Panel panelLastName;
        private System.Windows.Forms.TextBox txtRegLastName;
        private System.Windows.Forms.Panel panelFirstName;
        private System.Windows.Forms.TextBox txtRegFirstName;
        private System.Windows.Forms.Panel panelRetypePwd;
        private System.Windows.Forms.TextBox txtRegRetypePwd;
        private System.Windows.Forms.Panel panelPwd;
        private System.Windows.Forms.TextBox txtRegPwd;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.TextBox txtRegAmount;
    }
}