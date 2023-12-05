namespace Bank.UI
{
    partial class TimeDeposit
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timedeposit_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.PeriodCB = new System.Windows.Forms.ComboBox();
            this.timedeposit_AmountCB = new System.Windows.Forms.TextBox();
            this.TimeDepositButton = new ePOSOne.btnProduct.Button_WOC();
            this.timedeposit_Back = new System.Windows.Forms.Label();
            this.RateCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 10);
            this.panel2.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.timedeposit_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 80);
            this.panel1.TabIndex = 72;
            // 
            // timedeposit_Exit
            // 
            this.timedeposit_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timedeposit_Exit.AutoSize = true;
            this.timedeposit_Exit.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timedeposit_Exit.ForeColor = System.Drawing.Color.White;
            this.timedeposit_Exit.Location = new System.Drawing.Point(647, 3);
            this.timedeposit_Exit.Name = "timedeposit_Exit";
            this.timedeposit_Exit.Size = new System.Drawing.Size(29, 29);
            this.timedeposit_Exit.TabIndex = 9;
            this.timedeposit_Exit.Text = "X";
            this.timedeposit_Exit.Click += new System.EventHandler(this.timedeposit_Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIME DEPOSIT";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(91, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 27);
            this.label4.TabIndex = 77;
            this.label4.Text = "Deposit Type";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(86, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 27);
            this.label2.TabIndex = 78;
            this.label2.Text = "Period in Months";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(152, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 79;
            this.label3.Text = "AMOUNT";
            // 
            // TypeCB
            // 
            this.TypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Items.AddRange(new object[] {
            "Capitalisation",
            "Payment at the end"});
            this.TypeCB.Location = new System.Drawing.Point(247, 118);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(227, 31);
            this.TypeCB.TabIndex = 80;
            // 
            // PeriodCB
            // 
            this.PeriodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeriodCB.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.PeriodCB.FormattingEnabled = true;
            this.PeriodCB.Items.AddRange(new object[] {
            "3",
            "6",
            "9",
            "12",
            "18",
            "24"});
            this.PeriodCB.Location = new System.Drawing.Point(287, 175);
            this.PeriodCB.Name = "PeriodCB";
            this.PeriodCB.Size = new System.Drawing.Size(53, 33);
            this.PeriodCB.TabIndex = 81;
            // 
            // timedeposit_AmountCB
            // 
            this.timedeposit_AmountCB.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.timedeposit_AmountCB.Location = new System.Drawing.Point(268, 238);
            this.timedeposit_AmountCB.Name = "timedeposit_AmountCB";
            this.timedeposit_AmountCB.Size = new System.Drawing.Size(162, 33);
            this.timedeposit_AmountCB.TabIndex = 82;
            // 
            // TimeDepositButton
            // 
            this.TimeDepositButton.BackColor = System.Drawing.Color.Transparent;
            this.TimeDepositButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TimeDepositButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.TimeDepositButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeDepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeDepositButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeDepositButton.Location = new System.Drawing.Point(217, 296);
            this.TimeDepositButton.Name = "TimeDepositButton";
            this.TimeDepositButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.TimeDepositButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.TimeDepositButton.OnHoverTextColor = System.Drawing.Color.White;
            this.TimeDepositButton.Size = new System.Drawing.Size(162, 33);
            this.TimeDepositButton.TabIndex = 83;
            this.TimeDepositButton.Text = "DEPOSIT";
            this.TimeDepositButton.TextColor = System.Drawing.Color.White;
            this.TimeDepositButton.UseVisualStyleBackColor = false;
            this.TimeDepositButton.Click += new System.EventHandler(this.TimeDepositButton_Click);
            // 
            // timedeposit_Back
            // 
            this.timedeposit_Back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timedeposit_Back.AutoSize = true;
            this.timedeposit_Back.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.timedeposit_Back.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.timedeposit_Back.Location = new System.Drawing.Point(270, 361);
            this.timedeposit_Back.Name = "timedeposit_Back";
            this.timedeposit_Back.Size = new System.Drawing.Size(54, 19);
            this.timedeposit_Back.TabIndex = 84;
            this.timedeposit_Back.Text = "BACK";
            this.timedeposit_Back.Click += new System.EventHandler(this.timedeposit_Back_Click);
            // 
            // RateCB
            // 
            this.RateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RateCB.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.RateCB.FormattingEnabled = true;
            this.RateCB.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.RateCB.Location = new System.Drawing.Point(439, 175);
            this.RateCB.Name = "RateCB";
            this.RateCB.Size = new System.Drawing.Size(53, 33);
            this.RateCB.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(372, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 27);
            this.label5.TabIndex = 85;
            this.label5.Text = "Rate";
            // 
            // TimeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 393);
            this.Controls.Add(this.RateCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timedeposit_Back);
            this.Controls.Add(this.TimeDepositButton);
            this.Controls.Add(this.timedeposit_AmountCB);
            this.Controls.Add(this.PeriodCB);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timedeposit_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.ComboBox PeriodCB;
        private System.Windows.Forms.TextBox timedeposit_AmountCB;
        private ePOSOne.btnProduct.Button_WOC TimeDepositButton;
        private System.Windows.Forms.Label timedeposit_Back;
        private System.Windows.Forms.ComboBox RateCB;
        private System.Windows.Forms.Label label5;
    }
}