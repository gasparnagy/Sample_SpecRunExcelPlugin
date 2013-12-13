using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.App
{
    public class TaxInputModel
    {
        public int Year { get; set; }
        public decimal MonthlySalary { get; set; }
        public int NrOfChildren { get; set; }

        public TaxInputModel()
        {
            Year = 2013;
        }
    }
}
