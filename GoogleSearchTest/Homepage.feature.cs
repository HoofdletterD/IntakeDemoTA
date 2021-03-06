﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Transavia
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Navigate the Transavia.com website through the Homepage")]
    public partial class NavigateTheTransavia_ComWebsiteThroughTheHomepageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Homepage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Navigate the Transavia.com website through the Homepage", "\tAs a user and/or potential customer\r\n    I want to be able to find the links I n" +
                    "eed on the homepage \r\n    So that I can go to any part of the website that I cur" +
                    "rently need", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Homepage-001: Customer wants to know all the different destinations of Transavia." +
            "com")]
        [NUnit.Framework.CategoryAttribute("Homepage")]
        [NUnit.Framework.CategoryAttribute("Destionations")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void Homepage_001CustomerWantsToKnowAllTheDifferentDestinationsOfTransavia_Com()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Homepage-001: Customer wants to know all the different destinations of Transavia." +
                    "com", null, new string[] {
                        "Homepage",
                        "Destionations",
                        "Regression"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
 testRunner.Given("a user is on the Transavia.com homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.When("the user clicks on Bestemmingen in Secondary Menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("the user sees the page with the title \"Bestemmingen\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Homepage-002: Customer wants to register for the Newsletter")]
        [NUnit.Framework.CategoryAttribute("Homepage")]
        [NUnit.Framework.CategoryAttribute("Newsletter")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void Homepage_002CustomerWantsToRegisterForTheNewsletter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Homepage-002: Customer wants to register for the Newsletter", null, new string[] {
                        "Homepage",
                        "Newsletter",
                        "Regression"});
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 16
 testRunner.Given("a user is on the Transavia.com homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("the user fills the field \"Newsletter Subscription\" with \"Tester@mailinator.nl\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
    testRunner.And("the user clicks on Aanmelden", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("the user sees a confirmation of registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Homepage-003: Customer wants to find a flight")]
        [NUnit.Framework.CategoryAttribute("Homepage")]
        [NUnit.Framework.CategoryAttribute("Booking")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("1 Volwassene", "Amsterdam (Schiphol), Nederland", "Ljubljana, Slovenië", "15 dec 2018", "29 dec 2018", null)]
        [NUnit.Framework.TestCaseAttribute("1 Volwassene", "Eindhoven, Nederland", "Alicante, Spanje", "8 jan 2019", "20 feb 2019", null)]
        public virtual void Homepage_003CustomerWantsToFindAFlight(string no_OfPersons, string vanaf, string naar, string vertrek, string @return, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Homepage",
                    "Booking",
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Homepage-003: Customer wants to find a flight", null, @__tags);
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 24
 testRunner.Given("a user is on the Transavia.com homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.When(string.Format("the user searches for a flight for 1 Volwassene Leaving from \"{0}\" To \"{1}\" on \"{" +
                        "2}\" and back on \"{3}\"", vanaf, naar, vertrek, @return), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("the user sees the page with the title \"Boek een vlucht\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.And("the user can see Search Results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
