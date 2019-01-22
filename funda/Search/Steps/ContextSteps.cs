using OpenQA.Selenium;
using Search.UI;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Search
{
    
    [Binding]
    public class ContextSteps : BaseStep
    {   
        [Given(@"I have entered on the Funda homepage")]
        public void GivenIHaveEnteredOnTheFundaHomepage()
        {
            string url = ConfigurationManager.AppSettings["BaseUrl"];
            Driver.Navigate().GoToUrl(url);
        }

        [Given(@"I have data mass for sale and for rent")]
        public void GivenIHaveDataMassForSaleAndForRent()
        {

        }


    }
}
