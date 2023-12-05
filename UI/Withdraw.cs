using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.UI
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void withdraw_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void withdraw_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home window = new Home();
            window.Show();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            withdraw_Balance.Text = Program.сurrentAccount.Balance.ToString();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = int.Parse(withdraw_AmountTB.Text);
                Program.сurrentAccount.Withdraw(amount);
                this.Close();
                Home window = new Home();
                window.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the amount! The amount must be a whole number.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("The amount you want to withdraw cannot exceed your balance and must be greater than 0!");
            }
        }
    }
}
