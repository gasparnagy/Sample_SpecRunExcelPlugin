﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TaxCalculator.HuSpecs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Adószámítás (Gherkin)", new string[] {
            "gherkin-hu"}, SourceFile="TaxCalculation_Gherkin (hu).feature", SourceLine=3)]
    public partial class AdoszamitasGherkinFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TaxCalculation_Gherkin (hu).feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("hu-HU"), "Adószámítás (Gherkin)", "", ProgrammingLanguage.CSharp, new string[] {
                        "gherkin-hu"});
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Munkavállaló gyerekek nélkül", SourceLine=5)]
        public virtual void MunkavallaloGyerekekNelkul()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Munkavállaló gyerekek nélkül", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("a munkavállaló havi bruttó bére 200000 Ft", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Amennyiben ");
#line 8
 testRunner.And("a családban nincsenek gyerekek", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "És ");
#line 9
 testRunner.When("az adó kiszámításra kerül", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Amikor ");
#line 10
 testRunner.Then("nettó bérként 131000 Ft-ot kell kapjunk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Akkor ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void MunkavallaloGyerekekNelkulSO(string brutto, string netto, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Munkavállaló gyerekek nélkül (SO)", exampleTags);
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
 testRunner.Given(string.Format("a munkavállaló havi bruttó bére {0} Ft", brutto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Amennyiben ");
#line 15
 testRunner.And("a családban nincsenek gyerekek", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "És ");
#line 16
 testRunner.When("az adó kiszámításra kerül", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Amikor ");
#line 17
 testRunner.Then(string.Format("nettó bérként {0} Ft-ot kell kapjunk", netto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Akkor ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Munkavállaló gyerekek nélkül (SO), 100000", SourceLine=20)]
        public virtual void MunkavallaloGyerekekNelkulSO_100000()
        {
            this.MunkavallaloGyerekekNelkulSO("100000", "65500", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Munkavállaló gyerekek nélkül (SO), 200000", SourceLine=21)]
        public virtual void MunkavallaloGyerekekNelkulSO_200000()
        {
            this.MunkavallaloGyerekekNelkulSO("200000", "131000", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Munkavállaló gyerekek nélkül (SO), 300000", SourceLine=22)]
        public virtual void MunkavallaloGyerekekNelkulSO_300000()
        {
            this.MunkavallaloGyerekekNelkulSO("300000", "196500", ((string[])(null)));
        }
        
        public virtual void MunkavallaloGyerekekkel_Reszletes(string brutto, string netto, string jarulekok, string szja, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Munkavállaló gyerekekkel - részletes", exampleTags);
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
 testRunner.Given(string.Format("a munkavállaló havi bruttó bére {0} Ft", brutto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Amennyiben ");
#line 27
 testRunner.And("a családban nincsenek gyerekek", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "És ");
#line 28
 testRunner.When("az adó kiszámításra kerül", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Amikor ");
#line 29
 testRunner.Then(string.Format("nettó bérként {0} Ft-ot kell kapjunk", netto), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Akkor ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Járulékok",
                        "SZJA"});
            table1.AddRow(new string[] {
                        string.Format("{0}", jarulekok),
                        string.Format("{0}", szja)});
#line 30
 testRunner.And("az alábbi költségetet kell fizetnie a munkavállalónak", ((string)(null)), table1, "És ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Munkavállaló gyerekekkel - részletes, 100000", SourceLine=35)]
        public virtual void MunkavallaloGyerekekkel_Reszletes_100000()
        {
            this.MunkavallaloGyerekekkel_Reszletes("100000", "65500", "18000", "16000", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Munkavállaló gyerekekkel - részletes, 200000", SourceLine=36)]
        public virtual void MunkavallaloGyerekekkel_Reszletes_200000()
        {
            this.MunkavallaloGyerekekkel_Reszletes("200000", "131000", "37000", "32000", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Munkavállaló gyerekekkel - részletes, 300000", SourceLine=37)]
        public virtual void MunkavallaloGyerekekkel_Reszletes_300000()
        {
            this.MunkavallaloGyerekekkel_Reszletes("300000", "196500", "55500", "48000", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
