using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
   public static class TestEnvironment
    {
        private static ChromeDriver chromeDriver;


        public static ChromeDriver ChromeDriver
        {
            get { return chromeDriver ?? (chromeDriver = new ChromeDriver()); }
        }
    }
}
