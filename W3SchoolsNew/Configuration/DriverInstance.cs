using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3SchoolsNew.Configuration
{
    public class DriverInstance
    {
        private static IWebDriver driver;
        public static IWebDriver getDriverInstance()
        {
            switch (ConfigurationManager.AppSettings.Get("Browser"))
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

                case "IE":
                    driver = new InternetExplorerDriver();
                    break;

            }
            return driver;
        }
    }
}
