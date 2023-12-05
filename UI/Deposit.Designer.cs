namespace Bank.UI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.deposit_Exit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deposit_DepositButton = new ePOSOne.btnProduct.Button_WOC();
            this.deposit_AmountTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deposit_Back = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.deposit_Exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 80);
            this.panel1.TabIndex = 5;
            // 
            // deposit_Exit
            // 
            this.deposit_Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deposit_Exit.AutoSize = true;
            this.deposit_Exit.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deposit_Exit.ForeColor = System.Drawing.Color.White;
            this.deposit_Exit.Location = new System.Drawing.Point(501, 2);
            this.deposit_Exit.Name = "deposit_Exit";
            this.deposit_Exit.Size = new System.Drawing.Size(29, 29);
            this.deposit_Exit.TabIndex = 10;
            this.deposit_Exit.Text = "X";
            this.deposit_Exit.Click += new System.EventHandler(this.deposit_Exit_Click);
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
            this.label1.Location = new System.Drawing.Point(209, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPOSIT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(0, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 10);
            this.panel2.TabIndex = 70;
            // 
            // deposit_DepositButton
            // 
            this.deposit_DepositButton.BackColor = System.Drawing.Color.Transparent;
            this.deposit_DepositButton.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.deposit_DepositButton.ButtonColor = System.Drawing.Color.DarkSlateGray;
            this.deposit_DepositButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deposit_DepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit_DepositButton.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deposit_DepositButton.Location = new System.Drawing.Point(184, 202);
            this.deposit_DepositButton.Name = "deposit_DepositButton";
            this.deposit_DepositButton.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.deposit_DepositButton.OnHoverButtonColor = System.Drawing.Color.Teal;
            this.deposit_DepositButton.OnHoverTextColor = System.Drawing.Color.White;
            this.deposit_DepositButton.Size = new System.Drawing.Size(162, 33);
            this.deposit_DepositButton.TabIndex = 78;
            this.deposit_DepositButton.Text = "DEPOSIT";
            this.deposit_DepositButton.TextColor = System.Drawing.Color.White;
            this.deposit_DepositButton.UseVisualStyleBackColor = false;
            this.deposit_DepositButton.Click += new System.EventHandler(this.deposit_DepositButton_Click);
            // 
            // deposit_AmountTB
            // 
            this.deposit_AmountTB.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.deposit_AmountTB.Location = new System.Drawing.Point(265, 144);
            this.deposit_AmountTB.Name = "deposit_AmountTB";
            this.deposit_AmountTB.Size = new System.Drawing.Size(162, 33);
            this.deposit_AmountTB.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(139, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 76;
            this.label4.Text = "AMOUNT";
            // 
            // deposit_Back
            // 
            this.deposit_Back.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deposit_Back.AutoSize = true;
            this.deposit_Back.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.deposit_Back.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.deposit_Back.Location = new System.Drawing.Point(241, 292);
            this.deposit_Back.Name = "deposit_Back";
            this.deposit_Back.Size = new System.Drawing.Size(54, 19);
            this.deposit_Back.TabIndex = 75;
            this.deposit_Back.Text = "BACK";
            this.deposit_Back.Click += new System.EventHandler(this.deposit_Back_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 327);
            this.Controls.Add(this.deposit_DepositButton);
            this.Controls.Add(this.deposit_AmountTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deposit_Back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label deposit_Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC deposit_DepositButton;
        private System.Windows.Forms.TextBox deposit_AmountTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label deposit_Back;
    }
}