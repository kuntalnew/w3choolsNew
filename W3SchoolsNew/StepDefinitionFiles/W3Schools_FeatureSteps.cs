using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;
using TechTalk.SpecFlow;
using W3SchoolsNew.PageObjects;

namespace W3SchoolsNew.StepDefinitionFiles
{
    [Binding]
    public class W3Schools_FeatureSteps
    {
        private IWebDriver _driver;
        private W3schools_Home_page _home;
        private Try_Editor _editor;
        private HTML_Page _html;

        [BeforeScenario]
        public void TestSetUp()
        {
            _driver = Configuration.DriverInstance.getDriverInstance();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            _home = new W3schools_Home_page(_driver);
        }

        [AfterScenario]
        public void TestTearDown()
        {
            _driver.Dispose();
        }

        [Given]
        public void Given_I_am_on_the_home_page_of_w_P0_schools(int p0)
        {
            _driver.Navigate().GoToUrl(ExcelReader.Literals.ReadExcel(1, 0, "Url_links"));
        }
        
        [When]
        public void When_I_click_on_the_link_learn_html()
        {
            _html = _home.ClickOnLearnHtmlLink();
        }
        
        [When]
        public void When_I_click_on_the_link_Try_it_yourself()
        {
            _editor = _html.ClickOnTryYourselfLink();
        }
        
        [Then]
        public void Then_The_website_shoulod_navigate_to_the_html_home_screen()
        {
            Assert.AreEqual("https://www.w3schools.com/html/default.asp", ExcelReader.Literals.ReadExcel(1, 1, "Url_links"));
        }
        
        [Then]
        public void Then_the_heading_should_be_displayed_as_This_is_a_Heading()
        {
            ReadOnlyCollection<string> windows = _driver.WindowHandles;
            _driver.SwitchTo().Window(windows[1]);
            _driver.SwitchTo().Frame("iframeResult");
            Assert.AreEqual(ExcelReader.Literals.ReadExcel(4, 1, "Xpaths"), _driver.FindElement(By.XPath(ExcelReader.Literals.ReadExcel(3, 1, "Xpaths"))).Text);

        }
    }
}
