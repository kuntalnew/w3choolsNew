using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3SchoolsNew.ExcelReader;

namespace W3SchoolsNew.PageObjects
{
    public class HTML_Page
    {
        private IWebDriver _driver;
        private IWebElement try_yourself_linkText()
        {
            IWebElement element = _driver.FindElement(By.LinkText(ExcelReader.Literals.ReadExcel(2, 1, "Xpaths")));
            return element;

        }

        public HTML_Page(IWebDriver driver)
        {
            _driver = driver;
        }

        public Try_Editor ClickOnTryYourselfLink()
        {
            try_yourself_linkText().Click();
            return new Try_Editor(_driver);
        }
    }
}
