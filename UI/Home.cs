using Bank.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            home_AccNum.Text = Program.сurrentAccount.accountNumber;
        }

        private void home_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.сurrentAccount = null;
            Login window = new Login();
            window.Show();
        }

        private void home_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile window = new Profile();
            window.Show();
        }

        private void BalanceButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Balance window = new Balance();
            window.Show();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Deposit window = new Deposit();
            window.Show();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Withdraw window = new Withdraw();
            window.Show();
        }

        private void TimeDepositButton_Click(object sender, EventArgs e)
        {
            this.Close();
            TimeDeposit window = new TimeDeposit();
            window.Show();
        }
    }
}
