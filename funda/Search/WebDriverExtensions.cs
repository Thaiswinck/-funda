using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
  public static  class WebDriverExtensions
    {
        public static IWebElement GetElement(this IWebDriver driver, By by)
        {
            try
            {
                return driver.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static IWebElement GetElement(this IWebElement driver, By by)
        {
            try
            {
                return driver.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }

        public static ReadOnlyCollection<IWebElement> GetElements(this IWebDriver driver, By by)
        {
            try
            {
                return driver.FindElements(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
    }
}
