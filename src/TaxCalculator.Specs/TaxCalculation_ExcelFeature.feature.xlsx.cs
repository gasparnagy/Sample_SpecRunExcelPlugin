namespace SpecFlow.GeneratedTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Tax Calculation (Excel Feature)", new string[] {
            "excel-gherkin"}, SourceFile="TaxCalculation_ExcelFeature.feature.xlsx")]
    public partial class TaxCalculationExcelFeatureFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TaxCalculation_ExcelFeature.feature.xlsx"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Tax Calculation (Excel Feature)", "", ProgrammingLanguage.CSharp, new string[] {
                        "excel-gherkin"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Emplyee without children")]
        public virtual void EmplyeeWithoutChildren()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Emplyee without children", ((string[])(null)));
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given("the monthly gross salary of the employee is 200000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("there are no children in the family", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("the tax is calculated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("the monthly net salary of the employee should be 131000", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Social Security Contributions",
                        "Income Tax"});
            table3.AddRow(new string[] {
                        "37000",
                        "32000"});
            testRunner.And("the following taxes are paid by the employee", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void EmplyeeWithoutChildrenSO(string gross, string net, string[] exampleTags)
        {
            string[] @__tags = ((string[])(null));
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Emplyee without children (SO)", @__tags);
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given(string.Format("the monthly gross salary of the employee is {0}", gross), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And("there are no children in the family", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("the tax is calculated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("the monthly net salary of the employee should be {0}", net), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Emplyee without children (SO), 100000")]
        public virtual void EmplyeeWithoutChildrenSO_100000()
        {
            this.EmplyeeWithoutChildrenSO("100000", "65500", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Emplyee without children (SO), 200000")]
        public virtual void EmplyeeWithoutChildrenSO_200000()
        {
            this.EmplyeeWithoutChildrenSO("200000", "131000", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Emplyee without children (SO), 300000")]
        public virtual void EmplyeeWithoutChildrenSO_300000()
        {
            this.EmplyeeWithoutChildrenSO("300000", "196500", ((string[])(null)));
        }
        
        public virtual void EmplyeeWithChildren(string gross, string children, string net, string[] exampleTags)
        {
            string[] @__tags = ((string[])(null));
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Emplyee with children", @__tags);
            this.ScenarioSetup(scenarioInfo);
            testRunner.Given(string.Format("the monthly gross salary of the employee is {0}", gross), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.And(string.Format("there are {0} children in the family", children), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.When("the tax is calculated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then(string.Format("the monthly net salary of the employee should be {0}", net), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Emplyee with children, Variant 0")]
        public virtual void EmplyeeWithChildren_Variant0()
        {
            this.EmplyeeWithChildren("100000", "1", "75500", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Emplyee with children, Variant 1")]
        public virtual void EmplyeeWithChildren_Variant1()
        {
            this.EmplyeeWithChildren("100000", "2", "81500", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Emplyee with children, Variant 2")]
        public virtual void EmplyeeWithChildren_Variant2()
        {
            this.EmplyeeWithChildren("200000", "2", "151000", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Emplyee with children, Variant 3")]
        public virtual void EmplyeeWithChildren_Variant3()
        {
            this.EmplyeeWithChildren("200000", "3", "163000", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Emplyee with children, Variant 4")]
        public virtual void EmplyeeWithChildren_Variant4()
        {
            this.EmplyeeWithChildren("800000", "3", "623000", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
