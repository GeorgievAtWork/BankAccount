namespace Bank.Custom_Controls
{
    partial class Deposit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAmount = new System.Windows.Forms.Panel();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositTitle = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelAmount
            // 
            this.panelAmount.BackColor = System.Drawing.Color.White;
            this.panelAmount.ForeColor = System.Drawing.Color.Maroon;
            this.panelAmount.Location = new System.Drawing.Point(265, 203);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(200, 1);
            this.panelAmount.TabIndex = 30;
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.txtDepositAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepositAmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepositAmount.ForeColor = System.Drawing.Color.White;
            this.txtDepositAmount.Location = new System.Drawing.Point(265, 177);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(200, 20);
            this.txtDepositAmount.TabIndex = 29;
            this.txtDepositAmount.Text = "Amount";
            this.txtDepositAmount.TextChanged += new System.EventHandler(this.txtDepositAmount_TextChanged);
            this.txtDepositAmount.Enter += new System.EventHandler(this.txtDepositAmount_Focus);
            this.txtDepositAmount.Leave += new System.EventHandler(this.txtDepositAmount_Leave);
            // 
            // lblDepositTitle
            // 
            this.lblDepositTitle.AutoSize = true;
            this.lblDepositTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositTitle.ForeColor = System.Drawing.Color.White;
            this.lblDepositTitle.Location = new System.Drawing.Point(43, 24);
            this.lblDepositTitle.Name = "lblDepositTitle";
            this.lblDepositTitle.Size = new System.Drawing.Size(470, 25);
            this.lblDepositTitle.TabIndex = 31;
            this.lblDepositTitle.Text = "Input the amount that you want to deposit:";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.Lime;
            this.btnDeposit.Location = new System.Drawing.Point(590, 310);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(109, 43);
            this.btnDeposit.TabIndex = 32;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblDepositTitle);
            this.Controls.Add(this.panelAmount);
            this.Controls.Add(this.txtDepositAmount);
            this.MaximumSize = new System.Drawing.Size(731, 381);
            this.MinimumSize = new System.Drawing.Size(731, 381);
            this.Name = "Deposit";
            this.Size = new System.Drawing.Size(731, 381);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.Label lblDepositTitle;
        private System.Windows.Forms.Button btnDeposit;
    }
}
