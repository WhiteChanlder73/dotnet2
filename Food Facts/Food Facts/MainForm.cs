using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            NutritionForm nutritionInfo = new NutritionForm();

            if (bananaRadioButton.Checked)
            {
                nutritionInfo.foodLabel.Text = "Banana";
                nutritionInfo.caloriesLabel.Text = "100";
                nutritionInfo.fatLabel.Text = "0.4";
                nutritionInfo.carbLabel.Text = "27";
            }
            else if (popcornRadioButton.Checked)
            {
                nutritionInfo.foodLabel.Text = "1 cup air-popped popcorn";
                nutritionInfo.caloriesLabel.Text = "31";
                nutritionInfo.fatLabel.Text = "0.4";
                nutritionInfo.carbLabel.Text = "6";
            }
            else if (muffinRadioButton.Checked)
            {
                nutritionInfo.foodLabel.Text = "1 large blueberry muffin";
                nutritionInfo.caloriesLabel.Text = "385";
                nutritionInfo.fatLabel.Text = "9";
                nutritionInfo.carbLabel.Text = "67";
            }

            nutritionInfo.ShowDialog();
        }
    }
}
