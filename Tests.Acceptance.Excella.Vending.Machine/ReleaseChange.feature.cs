﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.Acceptance.Excella.Vending.Machine
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ReleaseChange")]
    public partial class ReleaseChangeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ReleaseChange.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ReleaseChange", "\tIn order to not donate all of my money to the vending machine company\r\n\tAs a pay" +
                    "ing customer\r\n\tI want to receive change back that isn\'t used to purchase a produ" +
                    "ct.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No change back when none given")]
        public virtual void NoChangeBackWhenNoneGiven()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No change back when none given", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I have not inserted a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("I release the change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("I should receive no change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Change Back When not purchasing a product")]
        public virtual void GetChangeBackWhenNotPurchasingAProduct()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Change Back When not purchasing a product", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given("I have inserted a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("I release the change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
 testRunner.Then("I should receive a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get all my change back when not purchasing")]
        public virtual void GetAllMyChangeBackWhenNotPurchasing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all my change back when not purchasing", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
 testRunner.Given("I have inserted a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
 testRunner.And("I have inserted a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I have inserted a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("I release the change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("I should receive 75 cents", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Remaining Change Back when I buy a product")]
        public virtual void GetRemainingChangeBackWhenIBuyAProduct()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Remaining Change Back when I buy a product", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("I have inserted a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.And("I have inserted a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I have inserted a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("I purchase a product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.And("I release the change", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("I should receive a quarter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
