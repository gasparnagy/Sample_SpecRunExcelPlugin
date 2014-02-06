﻿using System;
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

        [Given(@"a munkavállaló havi bruttó bére (.*) Ft")]
        public void GivenTheMonthlyGrossSalaryOfTheEmployeeIs(decimal grossSalary)
        {
            inputModel.MonthlySalary = grossSalary;
        }

        [Given(@"a családban nincsenek gyerekek")]
        public void GivenThereAreNoChildrenInTheFamily()
        {
            inputModel.NrOfChildren = 0;
        }

        [Given(@"there are (.*) children in the family")]
        public void GivenThereAreChildrenInTheFamily(int nrOfChildren)
        {
            inputModel.NrOfChildren = nrOfChildren;
        }

        [When(@"az adó kiszámításra kerül")]
        public void WhenTheTaxIsCalculated()
        {
            var calculator = new App.TaxCalculator();
            resultModel = calculator.Calculate(inputModel);
        }

        [Then(@"nettó bérként (.*) Ft-ot kell kapjunk")]
        public void ThenTheMonthlyNetSalaryOfTheEmployeeShouldBe(decimal netSalary)
        {
            resultModel.NetSalary.Should().Be(netSalary);
        }

        [Then(@"the following taxes are paid by the employer")]
        public void ThenTheFollowingTaxesArePaidByTheEmployer(Table expectedEmployerTaxes)
        {
        }

        [Then(@"az alábbi költségetet kell fizetnie a munkavállalónak")]
        public void ThenTheFollowingTaxesArePaidByTheEmployee(Table expectedEmployeeTaxes)
        {
        }
    }
}