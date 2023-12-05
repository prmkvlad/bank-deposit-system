using System.Windows.Forms;

namespace Bank
{
    partial class Signup
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
            this.signup_Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.signup_NameTB = new System.Windows.Forms.TextBox();
            this.signup_SurnameTB = new System.Windows.Forms.TextBox();
            this.signup_PatronymicTB = new System.Windows.Forms.TextBox();
            this.signup_BirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.signup_PhoneTB = new System.Windows.Forms.TextBox();
            this.signup_PasswordTB = new System.Windows.Forms.TextBox();
            this.signup_AddressTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signup_toLogin = new System.Windows.Forms.Label();
            this.signup_IDTB = new System.Windows.Forms.TextBox();
            this.signup_OccupationTB = new System.Windows.Forms.TextBox();
            this.signup_GenderCB = new System.Windows.Forms.ComboBox();
            this.SignupButton = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.signup_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 1;
            // 
            // signup_Exit
            // 
            this.signup_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signup_Exit.AutoSize = true;
            this.signup_Exit.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signup_Exit.ForeColor = System.Drawing.Color.White;
            this.signup_Exit.Location = new System.Drawing.Point(769, 2);
            this.signup_Exit.Name = "signup_Exit";
            this.signup_Exit.Size = new System.Drawing.Size(29, 29);
            this.signup_Exit.TabIndex = 9;
            this.signup_Exit.Text = "X";
            this.signup_Exit.Click += new System.EventHandler(this.signup_Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(237, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPENING A BANK ACCOUNT";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(138, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(100, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "SURNAME";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(68, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "PATRONYMIC";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(118, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "GENDER";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(97, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "BIRTHDAY";
            // 
            // signup_NameTB
            // 
            this.signup_NameTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.signup_NameTB.Location = new System.Drawing.Point(226, 124);
            this.signup_NameTB.Name = "signup_NameTB";
            this.signup_NameTB.Size = new System.Drawing.Size(162, 30);
            this.signup_NameTB.TabIndex = 17;
            // 
            // signup_SurnameTB
            // 
            this.signup_SurnameTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.signup_SurnameTB.Location = new System.Drawing.Point(226, 167);
            this.signup_SurnameTB.Name = "signup_SurnameTB";
            this.signup_SurnameTB.Size = new System.Drawing.Size(162, 30);
            this.signup_SurnameTB.TabIndex = 18;
            // 
            // signup_PatronymicTB
            // 
            this.signup_PatronymicTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.signup_PatronymicTB.Location = new System.Drawing.Point(226, 211);
            this.signup_PatronymicTB.Name = "signup_PatronymicTB";
            this.signup_PatronymicTB.Size = new System.Drawing.Size(162, 30);
            this.signup_PatronymicTB.TabIndex = 19;
            // 
            // signup_BirthdayPicker
            // 
            this.signup_BirthdayPicker.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signup_BirthdayPicker.Location = new System.Drawing.Point(226, 300);
            this.signup_BirthdayPicker.Format = DateTimePickerFormat.Custom;
            this.signup_BirthdayPicker.CustomFormat = "dd/MM/yyyy";
            this.signup_BirthdayPicker.MaxDate = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.signup_BirthdayPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.signup_BirthdayPicker.Name = "signup_BirthdayPicker";
            this.signup_BirthdayPicker.Size = new System.Drawing.Size(162, 27);
            this.signup_BirthdayPicker.TabIndex = 22;
            this.signup_BirthdayPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // signup_PhoneTB
            // 
            this.signup_PhoneTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.signup_PhoneTB.Location = new System.Drawing.Point(605, 207);
            this.signup_PhoneTB.Name = "signup_PhoneTB";
            this.signup_PhoneTB.Size = new System.Drawing.Size(162, 30);
            this.signup_PhoneTB.TabIndex = 32;
            // 
            // signup_PasswordTB
            // 
            this.signup_PasswordTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.signup_PasswordTB.Location = new System.Drawing.Point(605, 163);
            this.signup_PasswordTB.Name = "signup_PasswordTB";
            this.signup_PasswordTB.Size = new System.Drawing.Size(162, 30);
            this.signup_PasswordTB.TabIndex = 31;
            // 
            // signup_AddressTB
            // 
            this.signup_AddressTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.signup_AddressTB.Location = new System.Drawing.Point(605, 117);
            this.signup_AddressTB.Name = "signup_AddressTB";
            this.signup_AddressTB.Size = new System.Drawing.Size(162, 30);
            this.signup_AddressTB.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label15.Location = new System.Drawing.Point(451, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 23);
            this.label15.TabIndex = 28;
            this.label15.Text = "OCCUPATION";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label16.Location = new System.Drawing.Point(556, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 23);
            this.label16.TabIndex = 27;
            this.label16.Text = "ID";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label17.Location = new System.Drawing.Point(507, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 23);
            this.label17.TabIndex = 26;
            this.label17.Text = "PHONE";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label18.Location = new System.Drawing.Point(468, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 23);
            this.label18.TabIndex = 25;
            this.label18.Text = "PASSWORD";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label20.Location = new System.Drawing.Point(486, 124);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 23);
            this.label20.TabIndex = 23;
            this.label20.Text = "ADDRESS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 37;
            // 
            // signup_toLogin
            // 
            this.signup_toLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.signup_toLogin.AutoSize = true;
            this.signup_toLogin.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.signup_toLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.signup_toLogin.Location = new System.Drawing.Point(382, 426);
            this.signup_toLogin.Name = "signup_toLogin";
            this.signup_toLogin.Size = new System.Drawing.Size(61, 19);
            this.signup_toLogin.TabIndex = 39;
            this.signup_toLogin.Text = "LOGIN";
            this.signup_toLogin.Click += new System.EventHandler(this.signup_toLogin_Click);
            // 
            // signup_IDTB
            // 
            this.signup_IDTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.signup_IDTB.Location = new System.Drawing.Point(605, 251);
            this.signup_IDTB.Name = "signup_IDTB";
            this.signup_IDTB.Size = new System.Drawing.Size(162, 30);
            this.signup_IDTB.TabIndex = 40;
            // 
            // signup_OccupationTB
            // 
            this.signup_OccupationTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.signup_OccupationTB.Location = new System.Drawing.Point(605, 293);
            this.signup_OccupationTB.Name = "signup_OccupationTB";
            this.signup_OccupationTB.Size = new System.Drawing.Size(162, 30);
            this.signup_OccupationTB.TabIndex = 41;
            // 
            // signup_GenderCB
            // 
            this.signup_GenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signup_GenderCB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold);
            this.signup_GenderCB.FormattingEnabled = true;
            this.signup_GenderCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.signup_GenderCB.Location = new System.Drawing.Point(226, 255);
            this.signup_GenderCB.Name = "signup_GenderCB";
            this.signup_GenderCB.Size = new System.Drawing.Size(162, 31);
            this.signup_GenderCB.TabIndex = 42;
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.Color.Transparent;
            this.SignupButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.SignupButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.SignupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignupButton.Location = new System.Drawing.Point(329, 381);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.SignupButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.SignupButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SignupButton.Size = new System.Drawing.Size(162, 42);
            this.SignupButton.TabIndex = 38;
            this.SignupButton.Text = "SIGNUP";
            this.SignupButton.TextColor = System.Drawing.Color.White;
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.signup_GenderCB);
            this.Controls.Add(this.signup_OccupationTB);
            this.Controls.Add(this.signup_IDTB);
            this.Controls.Add(this.signup_toLogin);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.signup_PhoneTB);
            this.Controls.Add(this.signup_PasswordTB);
            this.Controls.Add(this.signup_AddressTB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.signup_BirthdayPicker);
            this.Controls.Add(this.signup_PatronymicTB);
            this.Controls.Add(this.signup_SurnameTB);
            this.Controls.Add(this.signup_NameTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signup_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox signup_NameTB;
        private System.Windows.Forms.TextBox signup_SurnameTB;
        private System.Windows.Forms.TextBox signup_PatronymicTB;
        private System.Windows.Forms.DateTimePicker signup_BirthdayPicker;
        private System.Windows.Forms.TextBox signup_PhoneTB;
        private System.Windows.Forms.TextBox signup_PasswordTB;
        private System.Windows.Forms.TextBox signup_AddressTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC SignupButton;
        private System.Windows.Forms.Label signup_toLogin;
        private System.Windows.Forms.TextBox signup_IDTB;
        private System.Windows.Forms.TextBox signup_OccupationTB;
        private System.Windows.Forms.ComboBox signup_GenderCB;
    }
}