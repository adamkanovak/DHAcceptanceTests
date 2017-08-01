﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DHAcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Tests related to the form page")]
    public partial class TestsRelatedToTheFormPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FormPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Tests related to the form page", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("REQ-UI-11 On the Form page, a form should be visible with one input box and one s" +
            "ubmit button")]
        [NUnit.Framework.CategoryAttribute("P1")]
        public virtual void REQ_UI_11OnTheFormPageAFormShouldBeVisibleWithOneInputBoxAndOneSubmitButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("REQ-UI-11 On the Form page, a form should be visible with one input box and one s" +
                    "ubmit button", new string[] {
                        "P1"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("the user is navigated to the site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When("the user clicks the Form button in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then("one input box should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
  testRunner.And("one submit button should be visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("REQ-UI-12 On the Form page, if you type value; the input field and submit the for" +
            "m, you should get redirect to the Hello page, and the following text should appe" +
            "ar: result")]
        [NUnit.Framework.CategoryAttribute("P1")]
        [NUnit.Framework.TestCaseAttribute("John", "Hello John!", null)]
        [NUnit.Framework.TestCaseAttribute("Sophia", "Hello Sophia!", null)]
        [NUnit.Framework.TestCaseAttribute("Charlie", "Hello Charlie!", null)]
        [NUnit.Framework.TestCaseAttribute("Emily", "Hello Emily!", null)]
        public virtual void REQ_UI_12OnTheFormPageIfYouTypeValueTheInputFieldAndSubmitTheFormYouShouldGetRedirectToTheHelloPageAndTheFollowingTextShouldAppearResult(string value, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "P1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("REQ-UI-12 On the Form page, if you type value; the input field and submit the for" +
                    "m, you should get redirect to the Hello page, and the following text should appe" +
                    "ar: result", @__tags);
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given("the user is navigated to the site", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.When("the user clicks the Form button in the header", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
  testRunner.And(string.Format("the user types the {0} into the input field", value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
  testRunner.And("the user clicks the Go! button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("the user should be redirected to the Hello page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
  testRunner.And(string.Format("the {0} text should be displayed", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
