namespace Bank.Custom_Controls
{
    partial class Withdraw
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.txtWithdrawAmount = new System.Windows.Forms.TextBox();
            this.lblWithdrawTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.Lime;
            this.btnWithdraw.Location = new System.Drawing.Point(590, 337);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(109, 43);
            this.btnWithdraw.TabIndex = 36;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // panelAmount
            // 
            this.panelAmount.BackColor = System.Drawing.Color.White;
            this.panelAmount.ForeColor = System.Drawing.Color.Maroon;
            this.panelAmount.Location = new System.Drawing.Point(265, 230);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(200, 1);
            this.panelAmount.TabIndex = 34;
            // 
            // txtWithdrawAmount
            // 
            this.txtWithdrawAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtWithdrawAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWithdrawAmount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithdrawAmount.ForeColor = System.Drawing.Color.White;
            this.txtWithdrawAmount.Location = new System.Drawing.Point(265, 204);
            this.txtWithdrawAmount.Name = "txtWithdrawAmount";
            this.txtWithdrawAmount.Size = new System.Drawing.Size(200, 20);
            this.txtWithdrawAmount.TabIndex = 33;
            this.txtWithdrawAmount.Text = "Amount";
            this.txtWithdrawAmount.TextChanged += new System.EventHandler(this.txtWithdrawAmount_TextChanged);
            this.txtWithdrawAmount.Enter += new System.EventHandler(this.txtWithdrawAmount_Focus);
            this.txtWithdrawAmount.Leave += new System.EventHandler(this.txtWithdrawAmount_Leave);
            // 
            // lblWithdrawTitle
            // 
            this.lblWithdrawTitle.AutoSize = true;
            this.lblWithdrawTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawTitle.ForeColor = System.Drawing.Color.White;
            this.lblWithdrawTitle.Location = new System.Drawing.Point(43, 51);
            this.lblWithdrawTitle.Name = "lblWithdrawTitle";
            this.lblWithdrawTitle.Size = new System.Drawing.Size(489, 25);
            this.lblWithdrawTitle.TabIndex = 35;
            this.lblWithdrawTitle.Text = "Input the amount that you want to withdraw:";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblWithdrawTitle);
            this.Controls.Add(this.panelAmount);
            this.Controls.Add(this.txtWithdrawAmount);
            this.MaximumSize = new System.Drawing.Size(731, 431);
            this.MinimumSize = new System.Drawing.Size(731, 431);
            this.Name = "Withdraw";
            this.Size = new System.Drawing.Size(731, 431);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.TextBox txtWithdrawAmount;
        private System.Windows.Forms.Label lblWithdrawTitle;
    }
}
