using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using TaxCalculator.App;
using TechTalk.SpecFlow;

namespace TaxCalculator.Specs
{
    [Binding]
    public class StepDefinitions
    {
        private TaxInputModel inputModel = new TaxInputModel();
        private TaxCalculationResultModel resultModel;

        [Given(@"the monthly gross salary of the employee is (.*)")]
        public void GivenTheMonthlyGrossSalaryOfTheEmployeeIs(decimal grossSalary)
        {
            inputModel.MonthlySalary = grossSalary;
        }

        [Given(@"there are no children in the family")]
        public void GivenThereAreNoChildrenInTheFamily()
        {
            inputModel.NrOfChildren = 0;
        }

        [Given(@"there are (.*) children in the family")]
        public void GivenThereAreChildrenInTheFamily(int nrOfChildren)
        {
            inputModel.NrOfChildren = nrOfChildren;
        }

        [When(@"the tax is calculated")]
        public void WhenTheTaxIsCalculated()
        {
            var calculator = new App.TaxCalculator();
            resultModel = calculator.Calculate(inputModel);
        }

        [Then(@"the monthly net salary of the employee should be (.*)")]
        public void ThenTheMonthlyNetSalaryOfTheEmployeeShouldBe(decimal netSalary)
        {
            resultModel.NetSalary.Should().Be(netSalary);
        }

        [Then(@"the following taxes are paid by the employer")]
        public void ThenTheFollowingTaxesArePaidByTheEmployer(Table expectedEmployerTaxes)
        {
        }

        [Then(@"the following taxes are paid by the employee")]
        public void ThenTheFollowingTaxesArePaidByTheEmployee(Table expectedEmployeeTaxes)
        {
        }
    }
}