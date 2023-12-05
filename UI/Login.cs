using Bank.Implementations;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_toSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup window = new Signup();
            window.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Finding a BankAccount object by account number in a hash table
            if (Program.bankAccounts.TryGetValue(login_AccountNumberTB.Text, out BankAccount userAccount))
            {
                if (userAccount.Password == login_PasswordTB.Text)
                {
                    MessageBox.Show("Authorisation was successful!");
                    Program.сurrentAccount = userAccount;
                    this.Hide();
                    Home window = new Home();
                    window.Show();
                }
                else
                {
                    MessageBox.Show("Invalid password!");
                }
            }
            else
            {
                MessageBox.Show("The user with this account number does not exist!");
            }
        }
    }
}
