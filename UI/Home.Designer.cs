namespace Bank
{
    partial class Home
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
            this.home_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeDepositButton = new ePOSOne.btnProduct.Button_WOC();
            this.WithdrawButton = new ePOSOne.btnProduct.Button_WOC();
            this.DepositButton = new ePOSOne.btnProduct.Button_WOC();
            this.ProfileButton = new ePOSOne.btnProduct.Button_WOC();
            this.BalanceButton = new ePOSOne.btnProduct.Button_WOC();
            this.home_Logout = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.home_AccNum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.home_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 80);
            this.panel1.TabIndex = 0;
            // 
            // home_Exit
            // 
            this.home_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.home_Exit.AutoSize = true;
            this.home_Exit.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.home_Exit.ForeColor = System.Drawing.Color.White;
            this.home_Exit.Location = new System.Drawing.Point(504, 3);
            this.home_Exit.Name = "home_Exit";
            this.home_Exit.Size = new System.Drawing.Size(29, 29);
            this.home_Exit.TabIndex = 2;
            this.home_Exit.Text = "X";
            this.home_Exit.Click += new System.EventHandler(this.home_Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Your Operation Please";
            // 
            // TimeDepositButton
            // 
            this.TimeDepositButton.BackColor = System.Drawing.Color.Transparent;
            this.TimeDepositButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TimeDepositButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.TimeDepositButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeDepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeDepositButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeDepositButton.Location = new System.Drawing.Point(34, 168);
            this.TimeDepositButton.Name = "TimeDepositButton";
            this.TimeDepositButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.TimeDepositButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.TimeDepositButton.OnHoverTextColor = System.Drawing.Color.White;
            this.TimeDepositButton.Size = new System.Drawing.Size(162, 42);
            this.TimeDepositButton.TabIndex = 10;
            this.TimeDepositButton.Text = "TIME DEPOSIT";
            this.TimeDepositButton.TextColor = System.Drawing.Color.White;
            this.TimeDepositButton.UseVisualStyleBackColor = false;
            this.TimeDepositButton.Click += new System.EventHandler(this.TimeDepositButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.BackColor = System.Drawing.Color.Transparent;
            this.WithdrawButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.WithdrawButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.WithdrawButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WithdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithdrawButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WithdrawButton.Location = new System.Drawing.Point(334, 168);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.WithdrawButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.WithdrawButton.OnHoverTextColor = System.Drawing.Color.White;
            this.WithdrawButton.Size = new System.Drawing.Size(162, 42);
            this.WithdrawButton.TabIndex = 11;
            this.WithdrawButton.Text = "WITHDRAW";
            this.WithdrawButton.TextColor = System.Drawing.Color.White;
            this.WithdrawButton.UseVisualStyleBackColor = false;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.BackColor = System.Drawing.Color.Transparent;
            this.DepositButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.DepositButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.DepositButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepositButton.Location = new System.Drawing.Point(34, 248);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.DepositButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.DepositButton.OnHoverTextColor = System.Drawing.Color.White;
            this.DepositButton.Size = new System.Drawing.Size(162, 42);
            this.DepositButton.TabIndex = 12;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.TextColor = System.Drawing.Color.White;
            this.DepositButton.UseVisualStyleBackColor = false;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.ProfileButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ProfileButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.ProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButton.Location = new System.Drawing.Point(185, 329);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.ProfileButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.ProfileButton.OnHoverTextColor = System.Drawing.Color.White;
            this.ProfileButton.Size = new System.Drawing.Size(162, 44);
            this.ProfileButton.TabIndex = 13;
            this.ProfileButton.Text = "PROFILE";
            this.ProfileButton.TextColor = System.Drawing.Color.White;
            this.ProfileButton.UseVisualStyleBackColor = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // BalanceButton
            // 
            this.BalanceButton.BackColor = System.Drawing.Color.Transparent;
            this.BalanceButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BalanceButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.BalanceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BalanceButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalanceButton.Location = new System.Drawing.Point(334, 248);
            this.BalanceButton.Name = "BalanceButton";
            this.BalanceButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.BalanceButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.BalanceButton.OnHoverTextColor = System.Drawing.Color.White;
            this.BalanceButton.Size = new System.Drawing.Size(162, 42);
            this.BalanceButton.TabIndex = 14;
            this.BalanceButton.Text = "BALANCE";
            this.BalanceButton.TextColor = System.Drawing.Color.White;
            this.BalanceButton.UseVisualStyleBackColor = false;
            this.BalanceButton.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // home_Logout
            // 
            this.home_Logout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.home_Logout.AutoSize = true;
            this.home_Logout.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.home_Logout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.home_Logout.Location = new System.Drawing.Point(229, 407);
            this.home_Logout.Name = "home_Logout";
            this.home_Logout.Size = new System.Drawing.Size(77, 19);
            this.home_Logout.TabIndex = 15;
            this.home_Logout.Text = "LOGOUT";
            this.home_Logout.Click += new System.EventHandler(this.home_Logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 10);
            this.panel2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(132, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Account number: ";
            // 
            // home_AccNum
            // 
            this.home_AccNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.home_AccNum.AutoSize = true;
            this.home_AccNum.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.home_AccNum.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.home_AccNum.Location = new System.Drawing.Point(339, 112);
            this.home_AccNum.Name = "home_AccNum";
            this.home_AccNum.Size = new System.Drawing.Size(104, 27);
            this.home_AccNum.TabIndex = 17;
            this.home_AccNum.Text = "AccNum";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 441);
            this.Controls.Add(this.home_AccNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.home_Logout);
            this.Controls.Add(this.BalanceButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.TimeDepositButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label home_Exit;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC TimeDepositButton;
        private ePOSOne.btnProduct.Button_WOC WithdrawButton;
        private ePOSOne.btnProduct.Button_WOC DepositButton;
        private ePOSOne.btnProduct.Button_WOC ProfileButton;
        private ePOSOne.btnProduct.Button_WOC BalanceButton;
        private System.Windows.Forms.Label home_Logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label home_AccNum;
    }
}