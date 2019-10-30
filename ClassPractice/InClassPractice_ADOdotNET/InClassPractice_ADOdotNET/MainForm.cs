using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassPractice_ADOdotNET
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tblFTCustomerInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFTCustomerInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quoteDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quoteDataSet.tblCarInfo' table. You can move, or remove it, as needed.
            this.tblCarInfoTableAdapter.Fill(this.quoteDataSet.tblCarInfo);
            // TODO: This line of code loads data into the 'quoteDataSet.tblFTCustomerInfo' table. You can move, or remove it, as needed.
            this.tblFTCustomerInfoTableAdapter.Fill(this.quoteDataSet.tblFTCustomerInfo);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
