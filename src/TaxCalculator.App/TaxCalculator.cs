using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.App
{
    public class TaxCalculator
    {
        public TaxCalculationResultModel Calculate(TaxInputModel inputModel)
        {
            var mpj = inputModel.MonthlySalary*0.015m;
            var ebj = inputModel.MonthlySalary*0.07m;
            var nyj = inputModel.MonthlySalary*0.1m;
            var szja = inputModel.MonthlySalary*0.16m;

            var taxRelief = inputModel.NrOfChildren <= 2 ? inputModel.NrOfChildren * 10000 : inputModel.NrOfChildren * 33000;
            szja = Math.Max(0m, szja - taxRelief);

            var paidByEmp = inputModel.MonthlySalary*0.29m;

            return new TaxCalculationResultModel()
            {
                NetSalary = inputModel.MonthlySalary - mpj - ebj - nyj - szja,
                TotalCost = inputModel.MonthlySalary + paidByEmp
            };
        }
    }
}
