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
        
        }
        /// <summary>
        /// CalculateButton Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Read
            const double PercentOfHoursWorked = 0.02;
            double TotalHoursWorked;
            double TotalMonthlySales;
            double TotalBonusAmount;
            double SalesBonus;

            TotalHoursWorked = Convert.ToDouble(HoursWorkedTextBox.Text);
            TotalMonthlySales = Convert.ToDouble(TotalSalesTextBox.Text);
            if (TotalHoursWorked >= 0 && TotalHoursWorked <= 160)
            {
                TotalBonusAmount = TotalMonthlySales * PercentOfHoursWorked;
                SalesBonus = PercentOfHoursWorked * TotalBonusAmount;

                SalesBonusTextBox.Text = SalesBonus.ToString();
            }

            else
            {
                MessageBox.Show("Hours Worked is not a valid number please chose a number between 0 and 160.");
            }

            }

        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Clear();
            EmployeeIdTextBox.Clear();
            HoursWorkedTextBox.Clear();
            SalesBonusTextBox.Clear();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Sales Bonus for this Employee was printed.");
        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeIdLabel.Text = "Employé ID";
            EmployeeNameLabel.Text = "Nom de l'employé";
            SalesBonusLabel.Text = "Bonus de vente";
            HoursWorkedLabel.Text = "Heures travaillées";
            TotalSalesLabel.Text = "Ventes totales";
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeIdLabel.Text = "Employee ID";
            EmployeeNameLabel.Text = "Employee Name";
            SalesBonusLabel.Text = "Sales Bonus";
            HoursWorkedLabel.Text = "Hours Worked";
            TotalSalesLabel.Text = "Total Sales";
        }
    }
    }

