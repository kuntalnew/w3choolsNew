using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3SchoolsNew.ExcelReader;

namespace W3SchoolsNew.PageObjects
{
    public class Try_Editor
    {
        private IWebDriver _driver;

        public IWebElement heading_Text()
        {
            //return _driver.FindElement(By.LinkText(Literals.ReadExcel(1, 3)));
            IWebElement element = _driver.FindElement(By.Id(""));
            return element;

        }

        public Try_Editor(IWebDriver driver)
        {
            _driver = driver;
        }

        public HTML_Page ClickOnLearnHtmlButton()
        {
            heading_Text().Click();
            return new HTML_Page(_driver);
        }
    }
}
