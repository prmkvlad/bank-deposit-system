using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Implementations
{
    internal class BankAccount : IBankOperations
    {
        private int balance = 0;
        public string accountNumber { get; private set; }
        private string password;
        public PersonData Person { get; private set; }
        public DateTime lastOperationDate { get; set; }

        public BankAccount(PersonData personData, string password)
        {
            Person = personData;
            accountNumber = new Random().Next(1000, 9999).ToString(); 
            this.password = password;
        }

        public int Balance
        {
            get => balance;
        }

        public string Password
        {
            get => password;
        }

        public void Deposit(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException();
            }
            balance += amount;
            lastOperationDate = DateTime.Now;
            MessageBox.Show($"Deposited: {amount} UAH. \nCurrent Balance: {balance} UAH.");
        }

        public void Withdraw(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException();
            }
            
            if (amount <= balance)
            {
                balance -= amount;
                lastOperationDate = DateTime.Now;
                MessageBox.Show($"Withdrawn: {amount} UAH. \nCurrent Balance: {balance} UAH.");
            }
            else
            {
                MessageBox.Show("Insufficient funds.");
                throw new ArgumentException();
            }
        }

        public int TimeDeposit(string type, int period, int rate, int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException();
            }
            int totalAmount;
            double years = (double)period / 12.0;
            if (type == "Payment at the end")
            {
                totalAmount = (int)(amount * (1 + rate / 100.0 * years));
            }
            else
            {
                double monthlyRate = (double)rate / 100.0 / 12.0; // monthly rate

                totalAmount = (int)(amount * Math.Pow(1 + monthlyRate, 12 * years));
            }
            return totalAmount;
        }
    }
}
