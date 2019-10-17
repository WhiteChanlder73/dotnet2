using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        // BankAccount field with $1000 starting balance 
        private BankAccount account = new BankAccount(1000);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display the starting balance 
            balanceLabel.Text = account.Balance.ToString("c");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount;

            // Convert the amount to decimal 
            if (decimal.TryParse(depositTextBox.Text, out amount))
            {
                // Deposit the amount into the account 
                account.Deposit(amount);

                // Display the new balance
                balanceLabel.Text = account.Balance.ToString("c");

                // Clear the textbox
                depositTextBox.Clear();
            }
            else
            {
                // Display error message 
                MessageBox.Show("Invalid Amount");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount; 

            if (decimal.TryParse(withdrawTextBox.Text, out amount))
            {
                account.Withdraw(amount);
                balanceLabel.Text = account.Balance.ToString("c");
                withdrawTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
