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
            this.txtRegUser = new System.Windows.Forms.TextBox();
            this.lblRegUser = new System.Windows.Forms.Label();
            this.lblRegPwd = new System.Windows.Forms.Label();
            this.txtRegPwd = new System.Windows.Forms.TextBox();
            this.lblRegRetypePwd = new System.Windows.Forms.Label();
            this.txtRegRetypePwd = new System.Windows.Forms.TextBox();
            this.lblRegFirstName = new System.Windows.Forms.Label();
            this.txtRegFirstName = new System.Windows.Forms.TextBox();
            this.lblRegLastName = new System.Windows.Forms.Label();
            this.txtRegLastName = new System.Windows.Forms.TextBox();
            this.lblRegAmount = new System.Windows.Forms.Label();
            this.txtRegAmount = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegError = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegWelcome
            // 
            this.lblRegWelcome.AutoSize = true;
            this.lblRegWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegWelcome.Location = new System.Drawing.Point(111, 62);
            this.lblRegWelcome.MaximumSize = new System.Drawing.Size(500, 300);
            this.lblRegWelcome.Name = "lblRegWelcome";
            this.lblRegWelcome.Size = new System.Drawing.Size(471, 58);
            this.lblRegWelcome.TabIndex = 0;
            this.lblRegWelcome.Text = "Hello and welcome to the registration form, please fill in all the needed informa" +
    "tion:";
            this.lblRegWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRegUser
            // 
            this.txtRegUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUser.Location = new System.Drawing.Point(322, 175);
            this.txtRegUser.Name = "txtRegUser";
            this.txtRegUser.Size = new System.Drawing.Size(147, 26);
            this.txtRegUser.TabIndex = 1;
            this.txtRegUser.TextChanged += new System.EventHandler(this.txtRegUser_TextChanged);
            // 
            // lblRegUser
            // 
            this.lblRegUser.AutoSize = true;
            this.lblRegUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegUser.Location = new System.Drawing.Point(181, 179);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(81, 18);
            this.lblRegUser.TabIndex = 2;
            this.lblRegUser.Text = "Username:";
            // 
            // lblRegPwd
            // 
            this.lblRegPwd.AutoSize = true;
            this.lblRegPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPwd.Location = new System.Drawing.Point(179, 210);
            this.lblRegPwd.Name = "lblRegPwd";
            this.lblRegPwd.Size = new System.Drawing.Size(82, 20);
            this.lblRegPwd.TabIndex = 4;
            this.lblRegPwd.Text = "Password:";
            // 
            // txtRegPwd
            // 
            this.txtRegPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPwd.Location = new System.Drawing.Point(322, 207);
            this.txtRegPwd.Name = "txtRegPwd";
            this.txtRegPwd.PasswordChar = '*';
            this.txtRegPwd.Size = new System.Drawing.Size(147, 26);
            this.txtRegPwd.TabIndex = 3;
            this.txtRegPwd.TextChanged += new System.EventHandler(this.txtRegPwd_TextChanged);
            // 
            // lblRegRetypePwd
            // 
            this.lblRegRetypePwd.AutoSize = true;
            this.lblRegRetypePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegRetypePwd.Location = new System.Drawing.Point(179, 242);
            this.lblRegRetypePwd.Name = "lblRegRetypePwd";
            this.lblRegRetypePwd.Size = new System.Drawing.Size(137, 20);
            this.lblRegRetypePwd.TabIndex = 6;
            this.lblRegRetypePwd.Text = "Retype Password:";
            // 
            // txtRegRetypePwd
            // 
            this.txtRegRetypePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegRetypePwd.Location = new System.Drawing.Point(322, 239);
            this.txtRegRetypePwd.Name = "txtRegRetypePwd";
            this.txtRegRetypePwd.PasswordChar = '*';
            this.txtRegRetypePwd.Size = new System.Drawing.Size(147, 26);
            this.txtRegRetypePwd.TabIndex = 5;
            this.txtRegRetypePwd.TextChanged += new System.EventHandler(this.txtRegRetypePwd_TextChanged);
            // 
            // lblRegFirstName
            // 
            this.lblRegFirstName.AutoSize = true;
            this.lblRegFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegFirstName.Location = new System.Drawing.Point(179, 274);
            this.lblRegFirstName.Name = "lblRegFirstName";
            this.lblRegFirstName.Size = new System.Drawing.Size(88, 20);
            this.lblRegFirstName.TabIndex = 8;
            this.lblRegFirstName.Text = "First name:";
            // 
            // txtRegFirstName
            // 
            this.txtRegFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegFirstName.Location = new System.Drawing.Point(322, 271);
            this.txtRegFirstName.Name = "txtRegFirstName";
            this.txtRegFirstName.Size = new System.Drawing.Size(147, 26);
            this.txtRegFirstName.TabIndex = 7;
            this.txtRegFirstName.TextChanged += new System.EventHandler(this.txtRegFirstName_TextChanged);
            // 
            // lblRegLastName
            // 
            this.lblRegLastName.AutoSize = true;
            this.lblRegLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegLastName.Location = new System.Drawing.Point(179, 306);
            this.lblRegLastName.Name = "lblRegLastName";
            this.lblRegLastName.Size = new System.Drawing.Size(88, 20);
            this.lblRegLastName.TabIndex = 10;
            this.lblRegLastName.Text = "Last name:";
            // 
            // txtRegLastName
            // 
            this.txtRegLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegLastName.Location = new System.Drawing.Point(322, 303);
            this.txtRegLastName.Name = "txtRegLastName";
            this.txtRegLastName.Size = new System.Drawing.Size(147, 26);
            this.txtRegLastName.TabIndex = 9;
            this.txtRegLastName.TextChanged += new System.EventHandler(this.txtRegLastName_TextChanged);
            // 
            // lblRegAmount
            // 
            this.lblRegAmount.AutoSize = true;
            this.lblRegAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegAmount.Location = new System.Drawing.Point(179, 338);
            this.lblRegAmount.Name = "lblRegAmount";
            this.lblRegAmount.Size = new System.Drawing.Size(69, 20);
            this.lblRegAmount.TabIndex = 12;
            this.lblRegAmount.Text = "Amount:";
            // 
            // txtRegAmount
            // 
            this.txtRegAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegAmount.Location = new System.Drawing.Point(322, 335);
            this.txtRegAmount.Name = "txtRegAmount";
            this.txtRegAmount.Size = new System.Drawing.Size(147, 26);
            this.txtRegAmount.TabIndex = 11;
            this.txtRegAmount.TextChanged += new System.EventHandler(this.txtRegAmount_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(277, 414);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(139, 71);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegError
            // 
            this.lblRegError.AutoSize = true;
            this.lblRegError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegError.ForeColor = System.Drawing.Color.Red;
            this.lblRegError.Location = new System.Drawing.Point(179, 388);
            this.lblRegError.Name = "lblRegError";
            this.lblRegError.Size = new System.Drawing.Size(0, 20);
            this.lblRegError.TabIndex = 14;
            this.lblRegError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(593, 511);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 38);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRegError);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblRegAmount);
            this.Controls.Add(this.txtRegAmount);
            this.Controls.Add(this.lblRegLastName);
            this.Controls.Add(this.txtRegLastName);
            this.Controls.Add(this.lblRegFirstName);
            this.Controls.Add(this.txtRegFirstName);
            this.Controls.Add(this.lblRegRetypePwd);
            this.Controls.Add(this.txtRegRetypePwd);
            this.Controls.Add(this.lblRegPwd);
            this.Controls.Add(this.txtRegPwd);
            this.Controls.Add(this.lblRegUser);
            this.Controls.Add(this.txtRegUser);
            this.Controls.Add(this.lblRegWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 600);
            this.MinimumSize = new System.Drawing.Size(710, 600);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegWelcome;
        private System.Windows.Forms.TextBox txtRegUser;
        private System.Windows.Forms.Label lblRegUser;
        private System.Windows.Forms.Label lblRegPwd;
        private System.Windows.Forms.TextBox txtRegPwd;
        private System.Windows.Forms.Label lblRegRetypePwd;
        private System.Windows.Forms.TextBox txtRegRetypePwd;
        private System.Windows.Forms.Label lblRegFirstName;
        private System.Windows.Forms.TextBox txtRegFirstName;
        private System.Windows.Forms.Label lblRegLastName;
        private System.Windows.Forms.TextBox txtRegLastName;
        private System.Windows.Forms.Label lblRegAmount;
        private System.Windows.Forms.TextBox txtRegAmount;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegError;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}