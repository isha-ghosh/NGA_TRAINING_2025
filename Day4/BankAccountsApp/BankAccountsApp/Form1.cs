using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount bankAccount = new BankAccount("Isha");
            //bankAccount.Owner = "Isha";
            //bankAccount.AccountNumber = Guid.NewGuid();
            //bankAccount.Balance = 250;

            BankAccount bankAccount1 = new BankAccount("Disha");
            //bankAccount1.Owner = "Disha";
            //bankAccount1.AccountNumber = Guid.NewGuid();
            //bankAccount1.Balance = 450;

            BankAccount bankAccount3 = new BankAccount("Mita");
            //bankAccount3.Owner = "Mita";
            //bankAccount3.AccountNumber = Guid.NewGuid();
            //bankAccount3.Balance = 650;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(bankAccount);
            bankAccounts.Add(bankAccount1);
            bankAccounts.Add(bankAccount3);
            BankAccountGrid.DataSource = bankAccounts;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Amount_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
