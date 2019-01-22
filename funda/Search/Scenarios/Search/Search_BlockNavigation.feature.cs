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
namespace Funda.Scenarios.Search
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class EnableOptionsOnTheNavigationBlockFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Search_BlockNavigation.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Enable options on the Navigation block", "\tTo avoid failures\r\n\tAs a quality analyst\r\n\tI want to check all the enabled field" +
                    "s on the navigation block", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Enable options on the Navigation block")))
            {
                global::Funda.Scenarios.Search.EnableOptionsOnTheNavigationBlockFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
testRunner.Given("I have entered on the Funda homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
testRunner.And("I have never visited the Funda website before", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("For Sale - enable fields")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Enable options on the Navigation block")]
        public virtual void ForSale_EnableFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Sale - enable fields", null, ((string[])(null)));
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 12
 testRunner.Given("I select the navigation item For Sale", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.Then("I see an autocomplete field to write the Location by city neighborhood or address" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.And("I see a dropdown field to select the ray", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("I see a dropdown field to select the price From", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("I see a dropdown field to select the price To", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("I see a button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.But("I do not see the label with the Last Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 19
 testRunner.And("I do not see a dropdown field to select the Country", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("For Rent - enable fields")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Enable options on the Navigation block")]
        public virtual void ForRent_EnableFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Rent - enable fields", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 23
 testRunner.Given("I select the navigation item For Rent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.Then("I see an autocomplete field to write the Location by city neighborhood or address" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.And("I see a dropdown field to select the ray", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I see a dropdown field to select the price From", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And("I see a dropdown field to select the price To", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I see a button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I see the Last Search label with the default text \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.But("I do not see a dropdown field to select the Country", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Newly Built - enable fields")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Enable options on the Navigation block")]
        public virtual void NewlyBuilt_EnableFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Newly Built - enable fields", null, ((string[])(null)));
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 35
 testRunner.Given("I select the navigation item Newly Built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.Then("I see an autocomplete field to write the Location by city neighborhood or address" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.And("I see a dropdown field to select the ray", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I see a button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("I see the Last Search label with the default text \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.But("I do not see a dropdown field to select the price From", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 41
 testRunner.And("I do not see a dropdown field to select the price To", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.But("I do not see a dropdown field to select the Country", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Recreation - enable fields")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Enable options on the Navigation block")]
        public virtual void Recreation_EnableFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recreation - enable fields", null, ((string[])(null)));
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 47
 testRunner.Given("I select the navigation item Recretion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.Then("I see an autocomplete field to write the Location by city neighborhood or address" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("I see a dropdown field to select the ray", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("I see a button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.But("I do not see a dropdown field to select the price From", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 52
 testRunner.And("I do not see a dropdown field to select the price To", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("I do not see the label with the Last Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And("I do not see a dropdown field to select the Country", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Europe - enable fields")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Enable options on the Navigation block")]
        public virtual void Europe_EnableFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Europe - enable fields", null, ((string[])(null)));
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 59
 testRunner.Given("I select the navigation item Europe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
 testRunner.Then("I have an dropdown field to select the Country", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.And("I have a dropdown field to select the ray", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("I have a button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.But("I do not see a dropdown field to select the price From", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 64
 testRunner.And("I do not see a dropdown field to select the price To", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("I do not see the label with the Last Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("I do not see an autocomplete field to write the Location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
