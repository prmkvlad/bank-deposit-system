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
    public partial class TimeDeposit : Form
    {
        public TimeDeposit()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timedeposit_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home window = new Home();
            window.Show();
        }

        private void timedeposit_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TimeDepositButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = int.Parse(timedeposit_AmountCB.Text);
                int period = int.Parse(PeriodCB.Text);
                int rate = int.Parse(RateCB.Text);
                if (string.IsNullOrWhiteSpace(TypeCB.Text))
                {
                    throw new ArgumentException();
                }
                int result = Program.сurrentAccount.TimeDeposit(TypeCB.Text, rate, period, amount);
                MessageBox.Show($"Total amount: {result} UAH.\nProfit: {result-amount} UAH.");
                this.Close();
                Home window = new Home();
                window.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the amount, period and rate! The amount must be a whole number.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("The amount must be greater than 0, and the Type, Period and Rate fields must not be empty!");
            }
        }
    }
}
