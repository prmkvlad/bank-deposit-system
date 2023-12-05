namespace Bank.UI
{
    partial class Balance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.balance_Balance = new System.Windows.Forms.Label();
            this.balance_AccNum = new System.Windows.Forms.Label();
            this.balance_Back = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.balance_Exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.balance_Exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 80);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(635, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BALANCE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(68, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account number: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(68, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Balance:";
            // 
            // balance_Balance
            // 
            this.balance_Balance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.balance_Balance.AutoSize = true;
            this.balance_Balance.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.balance_Balance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.balance_Balance.Location = new System.Drawing.Point(281, 194);
            this.balance_Balance.Name = "balance_Balance";
            this.balance_Balance.Size = new System.Drawing.Size(167, 27);
            this.balance_Balance.TabIndex = 7;
            this.balance_Balance.Text = "BalanceinUAH";
            // 
            // balance_AccNum
            // 
            this.balance_AccNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.balance_AccNum.AutoSize = true;
            this.balance_AccNum.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.balance_AccNum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.balance_AccNum.Location = new System.Drawing.Point(281, 147);
            this.balance_AccNum.Name = "balance_AccNum";
            this.balance_AccNum.Size = new System.Drawing.Size(104, 27);
            this.balance_AccNum.TabIndex = 6;
            this.balance_AccNum.Text = "AccNum";
            // 
            // balance_Back
            // 
            this.balance_Back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.balance_Back.AutoSize = true;
            this.balance_Back.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.balance_Back.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.balance_Back.Location = new System.Drawing.Point(235, 295);
            this.balance_Back.Name = "balance_Back";
            this.balance_Back.Size = new System.Drawing.Size(54, 19);
            this.balance_Back.TabIndex = 67;
            this.balance_Back.Text = "BACK";
            this.balance_Back.Click += new System.EventHandler(this.balance_Back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 10);
            this.panel2.TabIndex = 68;
            // 
            // balance_Exit
            // 
            this.balance_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.balance_Exit.AutoSize = true;
            this.balance_Exit.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance_Exit.ForeColor = System.Drawing.Color.White;
            this.balance_Exit.Location = new System.Drawing.Point(501, 2);
            this.balance_Exit.Name = "balance_Exit";
            this.balance_Exit.Size = new System.Drawing.Size(29, 29);
            this.balance_Exit.TabIndex = 10;
            this.balance_Exit.Text = "X";
            this.balance_Exit.Click += new System.EventHandler(this.balance_Exit_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.balance_Back);
            this.Controls.Add(this.balance_Balance);
            this.Controls.Add(this.balance_AccNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label balance_Balance;
        private System.Windows.Forms.Label balance_AccNum;
        private System.Windows.Forms.Label balance_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label balance_Exit;
    }
}