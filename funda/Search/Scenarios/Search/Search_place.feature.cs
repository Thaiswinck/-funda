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
    public partial class SearchByPlacesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Search_place.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search by places", "\tTo avoid failures\r\n\tAs a quality analyst\r\n\tI want to search on the site for diff" +
                    "erents places for Sale, for rent, in newly built, recreation and all Europe", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Search by places")))
            {
                global::Funda.Scenarios.Search.SearchByPlacesFeature.FeatureSetup(null);
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
#line 7
#line 8
testRunner.Given("I have a complet data mass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.And("I have entered on the Funda homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("For Sale - Find places in differents locations")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void ForSale_FindPlacesInDifferentsLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Sale - Find places in differents locations", null, ((string[])(null)));
#line 12
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 13
 testRunner.Given("I select the navigation item For Sale", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.And("I fill the field Location with value \'<Place>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.When("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I should go to the page \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Place"});
            table1.AddRow(new string[] {
                        "Bussum"});
            table1.AddRow(new string[] {
                        "Germaan"});
#line 17
 testRunner.And("I should see the same amount of results as DB <Place>", ((string)(null)), table1, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("For Sale - Last search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void ForSale_LastSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Sale - Last search", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 23
 testRunner.Given("I select the navigation item For Sale", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.And("I fill the field Location with value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("I back on the Funda homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("I have a field called \' \' with the value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("For Rent - Find places in differents locations")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void ForRent_FindPlacesInDifferentsLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Rent - Find places in differents locations", null, ((string[])(null)));
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 31
 testRunner.Given("I select the navigation item For Rent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.And("I fill the field Location with value \'<Place>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("I should go to the page \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Place"});
            table2.AddRow(new string[] {
                        "Bussum"});
            table2.AddRow(new string[] {
                        "Germaan"});
#line 35
 testRunner.And("I should see the same amount of results as DB <Place>", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("For Rent - Last search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void ForRent_LastSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("For Rent - Last search", null, ((string[])(null)));
#line 40
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 41
 testRunner.Given("I select the navigation item For Rent", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 42
 testRunner.And("I fill the field Location with value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.When("I back on the Funda homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("I have a field called \' \' with the value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Newly Built - Find places in differents locations")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void NewlyBuilt_FindPlacesInDifferentsLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Newly Built - Find places in differents locations", null, ((string[])(null)));
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 49
 testRunner.Given("I select the navigation item Newly Built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("I fill the field Location with value \'<Place>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.When("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("I should go to the page \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Place"});
            table3.AddRow(new string[] {
                        "Bussum"});
            table3.AddRow(new string[] {
                        "Germaan"});
#line 53
 testRunner.And("I should see the same amount of results as DB <Place>", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Newly Built - Last search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void NewlyBuilt_LastSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Newly Built - Last search", null, ((string[])(null)));
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 59
 testRunner.Given("I select the navigation item Newly Built", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
 testRunner.And("I fill the field Location with value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.When("I back on the Funda homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("I have a field called \' \' with the value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Recreation - Find places in differents locations")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void Recreation_FindPlacesInDifferentsLocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recreation - Find places in differents locations", null, ((string[])(null)));
#line 66
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 67
 testRunner.Given("I select the navigation item Recreation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.And("I fill the field Location with value \'<Place>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.When("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("I should go to the page \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Place"});
            table4.AddRow(new string[] {
                        "Bussum"});
            table4.AddRow(new string[] {
                        "Germaan"});
#line 71
 testRunner.And("I should see the same amount of results as DB <Place>", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Recreation - Last search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void Recreation_LastSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recreation - Last search", null, ((string[])(null)));
#line 76
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 77
 testRunner.Given("I select the navigation item Recreation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
 testRunner.And("I fill the field Location with value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.When("I back on the Funda homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then("I have a field called \' \' with the value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Europe - Find places in differents countries")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void Europe_FindPlacesInDifferentsCountries()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Europe - Find places in differents countries", null, ((string[])(null)));
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 85
 testRunner.Given("I select the navigation item Europe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 86
 testRunner.And("I fill the field Location with value \'<Country>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.When("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("I should go to the page \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Country"});
            table5.AddRow(new string[] {
                        "Bulgaria"});
            table5.AddRow(new string[] {
                        "Belgium"});
            table5.AddRow(new string[] {
                        "France"});
#line 89
 testRunner.And("I should see the same amount of results as DB <Place>", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Europe - Last search")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Search by places")]
        public virtual void Europe_LastSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Europe - Last search", null, ((string[])(null)));
#line 95
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
this.FeatureBackground();
#line 96
 testRunner.Given("I select the navigation item Europe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
 testRunner.And("I fill the field Location with value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("I click on the button Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.When("I back on the Funda homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
 testRunner.Then("I have a field called \' \' with the value \' \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion