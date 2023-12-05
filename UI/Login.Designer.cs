namespace Bank
{
    partial class Login
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
            this.login_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_AccountNumberTB = new System.Windows.Forms.TextBox();
            this.login_PasswordTB = new System.Windows.Forms.TextBox();
            this.login_toSignup = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginButton = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.login_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 80);
            this.panel1.TabIndex = 0;
            // 
            // login_Exit
            // 
            this.login_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login_Exit.AutoSize = true;
            this.login_Exit.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_Exit.ForeColor = System.Drawing.Color.White;
            this.login_Exit.Location = new System.Drawing.Point(504, 3);
            this.login_Exit.Name = "login_Exit";
            this.login_Exit.Size = new System.Drawing.Size(29, 29);
            this.login_Exit.TabIndex = 9;
            this.login_Exit.Text = "X";
            this.login_Exit.Click += new System.EventHandler(this.login_Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANK DEPOSIT SYSTEM";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(221, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(139, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "ACCOUNT NUMBER";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(214, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "PASSWORD";
            // 
            // login_AccountNumberTB
            // 
            this.login_AccountNumberTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.login_AccountNumberTB.Location = new System.Drawing.Point(349, 149);
            this.login_AccountNumberTB.Name = "login_AccountNumberTB";
            this.login_AccountNumberTB.Size = new System.Drawing.Size(162, 30);
            this.login_AccountNumberTB.TabIndex = 5;
            // 
            // login_PasswordTB
            // 
            this.login_PasswordTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.login_PasswordTB.Location = new System.Drawing.Point(349, 204);
            this.login_PasswordTB.Name = "login_PasswordTB";
            this.login_PasswordTB.Size = new System.Drawing.Size(162, 30);
            this.login_PasswordTB.TabIndex = 6;
            // 
            // login_toSignup
            // 
            this.login_toSignup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login_toSignup.AutoSize = true;
            this.login_toSignup.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.login_toSignup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.login_toSignup.Location = new System.Drawing.Point(397, 303);
            this.login_toSignup.Name = "login_toSignup";
            this.login_toSignup.Size = new System.Drawing.Size(72, 19);
            this.login_toSignup.TabIndex = 8;
            this.login_toSignup.Text = "SIGNUP";
            this.login_toSignup.Click += new System.EventHandler(this.login_toSignup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 10);
            this.panel2.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank.Properties.Resources.bank_account;
            this.pictureBox1.Location = new System.Drawing.Point(22, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.LoginButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(349, 256);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.LoginButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.LoginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LoginButton.Size = new System.Drawing.Size(162, 42);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.TextColor = System.Drawing.Color.White;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 341);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.login_toSignup);
            this.Controls.Add(this.login_PasswordTB);
            this.Controls.Add(this.login_AccountNumberTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox login_AccountNumberTB;
        private System.Windows.Forms.TextBox login_PasswordTB;
        private System.Windows.Forms.Label login_Exit;
        private System.Windows.Forms.Label login_toSignup;
        private ePOSOne.btnProduct.Button_WOC LoginButton;
        private System.Windows.Forms.Panel panel2;
    }
}