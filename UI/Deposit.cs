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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void deposit_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deposit_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home window = new Home();
            window.Show();
        }

        private void deposit_DepositButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = int.Parse(deposit_AmountTB.Text);
                Program.сurrentAccount.Deposit(amount);
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
                MessageBox.Show("The amount must be greater than 0!");
            }
        }
    }
}
