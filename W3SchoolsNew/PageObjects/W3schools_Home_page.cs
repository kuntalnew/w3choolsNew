using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3SchoolsNew.ExcelReader;

namespace W3SchoolsNew.PageObjects
{
    public class W3schools_Home_page
    {
        private IWebDriver _driver;

        private IWebElement learn_html_linkText()
        {
            IWebElement element = _driver.FindElement(By.LinkText(ExcelReader.Literals.ReadExcel(1, 1, "Xpaths")));
            return element;

        }

        public W3schools_Home_page(IWebDriver driver)
        {
            _driver = driver;
        }

        public HTML_Page ClickOnLearnHtmlLink()
        {
            learn_html_linkText().Click();
            return new HTML_Page(_driver);
        }
    }
}
