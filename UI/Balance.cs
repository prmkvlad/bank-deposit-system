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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void balance_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void balance_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home window = new Home();
            window.Show();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            balance_AccNum.Text = Program.сurrentAccount.accountNumber;
            balance_Balance.Text = $"{Program.сurrentAccount.Balance.ToString()} UAH";
        }
    }
}
