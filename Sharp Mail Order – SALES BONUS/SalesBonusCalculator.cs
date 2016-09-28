using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_Mail_Order___SALES_BONUS
{
    public partial class SalesBonusForm : Form
    {
        public SalesBonusForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(HoursWorkedTextBox.Text) >= 160 && int.Parse(HoursWorkedTextBox.Text) <= 0)
            {

            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            int hoursWorked = int.Parse(TotalSalesTextBox.Text);
            double totalBonusAmount = double.Parse(TotalSalesTextBox.Text) * 0.02;

            if (hoursWorked >= 160 && hoursWorked <= 0)
            {
              double percentOfHoursWorked = hoursWorked / 160;
              double salesBonus = percentOfHoursWorked* totalBonusAmount;
                SalesBonusTextBox.Text = salesBonus.ToString();

            }
        }
    }
}
