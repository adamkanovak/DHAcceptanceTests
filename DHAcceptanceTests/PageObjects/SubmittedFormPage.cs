using DHAcceptanceTests.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

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
            wait.Until(driver => HelloText.IsDisplayed());
            return HelloText.Text;
        }

        public bool IsDisplayed(string WebElementName)
        {
            wait.Until(driver => HelloText.IsDisplayed());
            switch (WebElementName)
            {
                case "HelloText":
                    return HelloText.IsDisplayed();
            }
            return false;
        }
    }
}
