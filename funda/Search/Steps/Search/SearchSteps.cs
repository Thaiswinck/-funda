using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Search.UI;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Search
{
 
    [Binding]
     public class SearchSteps : BaseStep
    {

        [Given(@"I select the navigation item For Sale")]
        public void GivenISelectTheNavigationItemForSale()
        {
            var sale = Driver.FindElement(Search_UI.MNU_sale);
            sale.Click();
        }

        [Then(@"I have a dropdown field called From with default value '(.*)'")]
        public void ThenIHaveADropdownFieldCalledFromWithDefaultValue(string value)
        {
            var optionDefault = Driver.FindElement(Search_UI.DDL_from_Selected);
            Assert.AreEqual(value, optionDefault, "The expected value is not the same as the received value");
        }

        [Then(@"I have a dropdown field called To with default value '(.*)'")]
        public void ThenIHaveADropdownFieldCalledToWithDefaultValue(string value)
        {
            var optionDefault = Driver.FindElement(Search_UI.DDL_To_Selected);
            Assert.AreEqual(value, optionDefault, "The expected value is not the same as the received value");

        }

        [When(@"I click on the dropdown fiel called From")]
        public void WhenIClickOnTheDropdownFielCalledFrom()
        {
            var name = Driver.FindElement(Search_UI.DDL_from);
            name.Click();
        }

        [When(@"I click on the dropdown field called To")]
        public void WhenIClickOnTheDropdownFielCalledTo()
        {
            var name = Driver.FindElement(Search_UI.DDL_to);
            name.Click();
        }

        [Then(@"I have on the dropdown field called To the options")]
        public void ThenIHaveOnTheDropdownFieldCalledToTheOptions(Table values)
        {
            var lista = Driver.GetElements(Search_UI.DDL_to_Options);

            if (lista.Count != values.Rows.Count)
                Assert.Fail("Different amount of columns");

            for (int i = 0; i < values.Rows.Count; i++)
            {
                Assert.IsTrue(lista[i].Text == values.Rows[i]["Options"], $"No column found with text {values.Rows[i]["Options"]}");
            }
        }


        [Given(@"I fill the field Location with value '(.*)'")]
        public void GivenIFillTheFieldLocationWithValue(string location)
        {
            var fill = Driver.FindElement(Search_UI.TXT_location);
            fill.SendKeys(location);
            var options = Driver.FindElement(Search_UI.TXT_location_Options);
            options.SendKeys(Keys.Down);
            options.SendKeys(Keys.Enter);
        }

        [Given(@"I select the field From with value '(.*)'")]
        public void GivenISelectTheFieldFromWithValue(string value)
        {
            SelectElement dropdown = new SelectElement(WaitElement(Search_UI.DDL_from));
            dropdown.SelectByText(value);

            if (dropdown == null)
            {
                Assert.Fail("Dropdownlist From not found");
            }
        }

        [Given(@"I select the field To with value '(.*)'")]
        public void GivenISelectTheFieldToWithValue(string value)
        {
            SelectElement dropdown = new SelectElement(WaitElement(Search_UI.DDL_to));
            dropdown.SelectByText(value);

            if (dropdown == null)
            {
                Assert.Fail("Dropdownlist From not found");
            }
        }

        [When(@"I click on the button Search")]
        public void WhenIClickOnTheButtonSearch()
        {
            var click = Driver.FindElement(Search_UI.BTN_search);
            click.Click();
        }

        [Then(@"I should go to the page '(.*)'")]
        public void ThenIShouldGoToThePage(string page)
        {
            string url = ConfigurationManager.AppSettings["BaseUrl"];
            string currentURL = Driver.Url;
            Assert.AreEqual($"{url}{page}", currentURL, "The expected URL is not the same as the received URL");
        }

        [Then(@"I should see the same amount of results as DB (.*) (.*) (.*)")]
        public void ThenIShouldSeeTheSameAmountOfResultsAsDB(string p0, string p1, string p2, Table table)
        {
           //Here we can get the total amount on the page and compare with a select on the DB
        }

        [Then(@"I select the field From with Other value")]
        public void ThenISelectTheFieldFromWithOtherValue()
        {
            SelectElement dropdown = new SelectElement(WaitElement(Search_UI.DDL_from));
            dropdown.SelectByText("other");

            if (dropdown == null)
            {
                Assert.Fail("Dropdownlist From not found");
            }
        }

        [Then(@"I fill the field From with the value '(.*)'")]
        public void ThenIFillTheFieldFromWithTheValue(string value)
        {
            var input = Driver.FindElement(Search_UI.TXT_from);
            input.SendKeys(value);
        }

        [Then(@"I select the field To with Other value")]
        public void ThenISelectTheFieldToWithOtherValue()
        {
            SelectElement dropdown = new SelectElement(WaitElement(Search_UI.DDL_to));
            dropdown.SelectByText("other");

            if (dropdown == null)
            {
                Assert.Fail("Dropdownlist To not found");
            }
        }

        [Then(@"I fill the field To with the value '(.*)'")]
        public void ThenIFillTheFieldToWithTheValue(string value)
        {
            var input = Driver.FindElement(Search_UI.TXT_to);
            input.SendKeys(value);
        }

        [Given(@"I select the navigation item For Rent")]
        public void GivenISelectTheNavigationItemForRent()
        {
            var sale = Driver.FindElement(Search_UI.MNU_sale);
            sale.Click();
        }

        [When(@"I click on the dropdown fiel To")]
        public void WhenIClickOnTheDropdownFielTo()
        {
            var sale = Driver.FindElement(Search_UI.DDL_to);
            sale.Click();
        }

        [Then(@"I have on the dropdown field called From the options")]
        public void ThenIHaveTheOptionsOnTheDropdownFieldCalledTo(Table values)
        {
            var lista = Driver.GetElements(Search_UI.DDL_from_Options);

            if (lista.Count != values.Rows.Count)
                Assert.Fail("Different amount of columns");

            for (int i = 0; i < values.Rows.Count; i++)
            {
                Assert.IsTrue(lista[i].Text == values.Rows[i]["Options"], $"No column found with text {values.Rows[i]["Options"]}");
            }
        }

        [Then(@"I see a dropdown field to select the ray")]
        public void ThenISeeADropdownFieldToSelectTheRay()
        {
            var ray = WaitElement(Search_UI.DDL_ray);
            if (ray == null)
            {
                Assert.Fail("Ray element not found");
            }
        }

        [Then(@"I do not see a dropdown field to select the Country")]
        public void ThenIDoNotSeeADropdownFieldToSelectTheCountry()
        {
            var country = WaitElement(Search_UI.DDL_Country);
            if (country != null)
            {
                Assert.Fail("Coutry element found");
            }
        }








    }
}
