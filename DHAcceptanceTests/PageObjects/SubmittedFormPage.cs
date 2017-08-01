using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHAcceptanceTests.PageObjects
{
    public class SubmittedFormPage
    {
        private readonly IWebDriver _driver;
        private WebDriverWait wait;

        [FindsBy(How = How.Id, Using = "hello-text")]
        private IWebElement HelloText { get; set; }

        public SubmittedFormPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1));
        }

        public string GetHelloText()
        {
            wait.Until(driver => HelloText.Displayed);
            return HelloText.Text;
        }

        public bool IsDisplayed(string WebElementName)
        {
            wait.Until(driver => HelloText.Displayed);
            switch (WebElementName)
            {
                case "HelloText":
                    return HelloText.Displayed;
            }
            return false;
        }
    }
}
