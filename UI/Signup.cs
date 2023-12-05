using Bank.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            string name = signup_NameTB.Text;
            string surname = signup_SurnameTB.Text;
            string patronymic = signup_PatronymicTB.Text;
            string gender = signup_GenderCB.Text;
            string address = signup_AddressTB.Text;
            string password = signup_PasswordTB.Text;
            string phone = signup_PhoneTB.Text;
            string id = signup_IDTB.Text;
            string occupation = signup_OccupationTB.Text;
            DateTime birthday = signup_BirthdayPicker.Value;

            // Checking the correctness of the entered data
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(patronymic) ||
                string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(password) ||
                !Regex.IsMatch(phone, @"^\d{10}$") ||
                !Regex.IsMatch(id, @"^\d{10}$") ||
                string.IsNullOrWhiteSpace(occupation))
            {
                MessageBox.Show("Please check that the data you have entered is correct. There must be no empty fields, and the phone number and ID must be 10 digits long.");
            }
            else
            {
                PersonData data = new PersonData(name, surname, patronymic, gender, birthday, address, phone, id, occupation);
                BankAccount account = new BankAccount(data, password);
                Program.bankAccounts.Add(account.accountNumber, account); 
                Program.сurrentAccount = account;
                MessageBox.Show("Registration is successful!");

                this.Close();
                Home window = new Home();
                window.Show();
            }
        }

        private void signup_toLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Login window = new Login();
            window.Show();
        }

        private void signup_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
