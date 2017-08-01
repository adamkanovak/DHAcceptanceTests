using DHAcceptanceTests.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace DHAcceptanceTests.PageObjects
{
    public class Header
    {
        private readonly IWebDriver _driver;
        private WebDriverWait wait;

        [FindsBy(How = How.Id, Using = "site")]
        private IWebElement UITestingButton { get; set; }

        [FindsBy(How = How.Id, Using = "home")]
        private IWebElement HomeButton { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        private IWebElement FormButton { get; set; }

        [FindsBy(How = How.Id, Using = "error")]
        private IWebElement ErrorButton { get; set; }

        public Header(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1));
           
        }

        public Header ClickUItestingButton()
        {
            wait.Until(driver => UITestingButton.Displayed);
            UITestingButton.Click();
            return this;
        }

        public Header ClickHomeButton()
        {
            wait.Until(driver => HomeButton.Displayed);
            HomeButton.Click();
            return this;
        }

        public Header ClickFormButton()
        {
            wait.Until(driver => FormButton.Displayed);
            FormButton.Click();
            return this;
        }

        public Header ClickErrorButton()
        {
            wait.Until(driver => ErrorButton.Displayed);
            ErrorButton.Click();
            return this;
        }

        public bool IsDisplayed(string WebElementName)
        {
            wait.Until(driver => HomeButton.Displayed);
            switch (WebElementName)
            {
                case "UITestingButton":
                    return UITestingButton.Displayed;
                case "HomeButton":
                    return HomeButton.Displayed;
                case "FormButton":
                    return FormButton.Displayed;
                case "ErrorButton":
                    return ErrorButton.Displayed;
            }
            return false;
        }
    }
}