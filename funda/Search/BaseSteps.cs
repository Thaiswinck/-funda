using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Search
{
    [Binding]
    public abstract class BaseStep
    {
        public static IWebDriver Driver
        {
            get
            {
                if (InnerDriver == null)
                    InnerDriver = TestEnvironment.ChromeDriver;

                return InnerDriver;
            }
        }

        public IWebElement WaitElement(By by)
        {
            WebDriverWait waiter = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            waiter.Until(ExpectedConditions.ElementExists(by));

            return Driver.GetElement(by);
        }

        public static void WaitClickable(IWebElement element)
        {
            int count = 0;
            while (element.Enabled == false ||
                      element.Displayed == false)
            {
                int value = ++count;
                if (value < 6)
                    Thread.Sleep(500);
                else
                {
                    Assert.Fail("Botão encontrasse desabilitado após 4 tentativas ");
                }
            }
        }

      
        [BeforeScenario()]
        public static void CleanCookies()
        {

            Driver?.Manage().Cookies.DeleteAllCookies();
        }

        [BeforeScenario()]
        public static void CleanLocalStorage()
        {
            try
            {
                IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
                js.ExecuteScript("localStorage.clear()");
                js.ExecuteScript("sessionStorage.clear()");
            }
            catch { };
        }


        [BeforeScenario("maximize")]
        public static void Maximize()
        {
            InnerDriver.Manage().Window.Maximize();
        }


        private static IWebDriver InnerDriver { get; set; }
    }

}
