namespace Bank.UI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.withdraw_Exit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.withdraw_Back = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.withdraw_Balance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.withdraw_AmountTB = new System.Windows.Forms.TextBox();
            this.WithdrawButton = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.withdraw_Exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 80);
            this.panel1.TabIndex = 4;
            // 
            // withdraw_Exit
            // 
            this.withdraw_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.withdraw_Exit.AutoSize = true;
            this.withdraw_Exit.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdraw_Exit.ForeColor = System.Drawing.Color.White;
            this.withdraw_Exit.Location = new System.Drawing.Point(501, 2);
            this.withdraw_Exit.Name = "withdraw_Exit";
            this.withdraw_Exit.Size = new System.Drawing.Size(29, 29);
            this.withdraw_Exit.TabIndex = 10;
            this.withdraw_Exit.Text = "X";
            this.withdraw_Exit.Click += new System.EventHandler(this.withdraw_Exit_Click);
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
            this.label1.Location = new System.Drawing.Point(191, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "WITHDRAW";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 10);
            this.panel2.TabIndex = 69;
            // 
            // withdraw_Back
            // 
            this.withdraw_Back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.withdraw_Back.AutoSize = true;
            this.withdraw_Back.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.withdraw_Back.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw_Back.Location = new System.Drawing.Point(240, 295);
            this.withdraw_Back.Name = "withdraw_Back";
            this.withdraw_Back.Size = new System.Drawing.Size(54, 19);
            this.withdraw_Back.TabIndex = 68;
            this.withdraw_Back.Text = "BACK";
            this.withdraw_Back.Click += new System.EventHandler(this.withdraw_Back_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(82, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 27);
            this.label3.TabIndex = 70;
            this.label3.Text = "AVAILABLE BALANCE: ";
            // 
            // withdraw_Balance
            // 
            this.withdraw_Balance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.withdraw_Balance.AutoSize = true;
            this.withdraw_Balance.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.withdraw_Balance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw_Balance.Location = new System.Drawing.Point(330, 129);
            this.withdraw_Balance.Name = "withdraw_Balance";
            this.withdraw_Balance.Size = new System.Drawing.Size(99, 27);
            this.withdraw_Balance.TabIndex = 71;
            this.withdraw_Balance.Text = "Balance";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(138, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 72;
            this.label4.Text = "AMOUNT";
            // 
            // withdraw_AmountTB
            // 
            this.withdraw_AmountTB.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.withdraw_AmountTB.Location = new System.Drawing.Point(264, 173);
            this.withdraw_AmountTB.Name = "withdraw_AmountTB";
            this.withdraw_AmountTB.Size = new System.Drawing.Size(162, 33);
            this.withdraw_AmountTB.TabIndex = 73;
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.BackColor = System.Drawing.Color.Transparent;
            this.WithdrawButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.WithdrawButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.WithdrawButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WithdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithdrawButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WithdrawButton.Location = new System.Drawing.Point(183, 231);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.WithdrawButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.WithdrawButton.OnHoverTextColor = System.Drawing.Color.White;
            this.WithdrawButton.Size = new System.Drawing.Size(162, 33);
            this.WithdrawButton.TabIndex = 74;
            this.WithdrawButton.Text = "WITHDRAW";
            this.WithdrawButton.TextColor = System.Drawing.Color.White;
            this.WithdrawButton.UseVisualStyleBackColor = false;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 327);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.withdraw_AmountTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.withdraw_Balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.withdraw_Back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label withdraw_Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label withdraw_Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label withdraw_Balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox withdraw_AmountTB;
        private ePOSOne.btnProduct.Button_WOC WithdrawButton;
    }
}