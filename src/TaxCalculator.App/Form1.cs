using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var inputModel = new TaxInputModel
            {
                MonthlySalary = salaryUpDown.Value, 
                NrOfChildren = (int)childrenUpDown.Value
            };

            var calculator = new TaxCalculator();

            var result = calculator.Calculate(inputModel);

            var resultBuilder = new StringBuilder();
            resultBuilder.AppendFormat("Net salary: {0} Ft", result.NetSalary);
            resultBuilder.AppendLine();
            resultBuilder.AppendFormat("Total cost: {0} Ft", result.TotalCost);
            resultBuilder.AppendLine();

            resultTextBox.Text = resultBuilder.ToString();
        }
    }
}
