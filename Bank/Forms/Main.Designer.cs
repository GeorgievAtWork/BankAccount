﻿namespace Bank
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblMainWelcome = new System.Windows.Forms.Label();
            this.lblBalanceText = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.Lime;
            this.btnDeposit.Location = new System.Drawing.Point(137, 290);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(7, 4, 0, 0);
            this.btnDeposit.Size = new System.Drawing.Size(120, 90);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "+";
            this.btnDeposit.UseVisualStyleBackColor = false;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.Window;
            this.btnWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.Lime;
            this.btnWithdraw.Location = new System.Drawing.Point(410, 290);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(7, 0, 0, 10);
            this.btnWithdraw.Size = new System.Drawing.Size(120, 90);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "-";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            // 
            // lblMainWelcome
            // 
            this.lblMainWelcome.AutoSize = true;
            this.lblMainWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainWelcome.Location = new System.Drawing.Point(280, 27);
            this.lblMainWelcome.Name = "lblMainWelcome";
            this.lblMainWelcome.Size = new System.Drawing.Size(113, 25);
            this.lblMainWelcome.TabIndex = 2;
            this.lblMainWelcome.Text = "Welcome, ";
            // 
            // lblBalanceText
            // 
            this.lblBalanceText.AutoSize = true;
            this.lblBalanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceText.Location = new System.Drawing.Point(261, 168);
            this.lblBalanceText.Name = "lblBalanceText";
            this.lblBalanceText.Size = new System.Drawing.Size(91, 24);
            this.lblBalanceText.TabIndex = 3;
            this.lblBalanceText.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(358, 168);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(47, 24);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "hold";
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.Window;
            this.btnLog.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.Lime;
            this.btnLog.Location = new System.Drawing.Point(275, 290);
            this.btnLog.Name = "btnLog";
            this.btnLog.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLog.Size = new System.Drawing.Size(120, 90);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(232, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(202, 31);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 457);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblBalanceText);
            this.Controls.Add(this.lblMainWelcome);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(683, 496);
            this.MinimumSize = new System.Drawing.Size(683, 496);
            this.Name = "Main";
            this.Text = "Bank Account";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblMainWelcome;
        private System.Windows.Forms.Label lblBalanceText;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblName;
    }
}