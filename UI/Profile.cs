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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void profile_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            profile_AccountNumberTB.Text = Program.сurrentAccount.accountNumber;
            profile_NameTB.Text = Program.сurrentAccount.Person.name;
            profile_SurnameTB.Text = Program.сurrentAccount.Person.surname;
            profile_PatronymicTB.Text = Program.сurrentAccount.Person.patronymic;
            profile_GenderTB.Text = Program.сurrentAccount.Person.gender;
            profile_BirthdayTB.Text = Program.сurrentAccount.Person.birthDate.ToString("dd/MM/yyyy");
            profile_AddressTB.Text = Program.сurrentAccount.Person.address;
            profile_BalanceTB.Text = Program.сurrentAccount.Balance.ToString();
            profile_OccupationTB.Text = Program.сurrentAccount.Person.occupation;
            profile_PhoneTB.Text = Program.сurrentAccount.Person.phone;
            profile_IDTB.Text = Program.сurrentAccount.Person.ID;
            if (Program.сurrentAccount.lastOperationDate != DateTime.MinValue)
            {
                LastOperationTB.Text = Program.сurrentAccount.lastOperationDate.ToString();
            }    
        }

        private void profile_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Home window = new Home();
            window.Show();
        }
    }
}
