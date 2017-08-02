using DHAcceptanceTests.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace DHAcceptanceTests.PageObjects
{
    class Header
    {
        private readonly IWebDriver _driver;
        private WebDriverWait wait;

        [FindsBy(How = How.Id, Using = "site")]
        private IWebElement UITestingButton { get; set; }

        [FindsBy(How = How.Id, Using = "home")]
        private IWebElement HomeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li[class='active']>a[id='home']")]
        private IWebElement ActiveHomeButton { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        private IWebElement FormButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li[class='active']>a[id='form']")]
        private IWebElement ActiveFormButton { get; set; }

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
            wait.Until(driver => UITestingButton.IsDisplayed());
            UITestingButton.Click();
            return this;
        }

        public Header ClickHomeButton()
        {
            wait.Until(driver => HomeButton.IsDisplayed());
            HomeButton.Click();
            return this;
        }

        public Header ClickFormButton()
        {
            wait.Until(driver => FormButton.IsDisplayed());
            FormButton.Click();
            return this;
        }

        public Header ClickErrorButton()
        {
            wait.Until(driver => ErrorButton.IsDisplayed());
            ErrorButton.Click();
            return this;
        }

        public bool IsDisplayed(string WebElementName)
        {
            wait.Until(driver => HomeButton.IsDisplayed());
            switch (WebElementName)
            {
                case "UITestingButton":
                    return UITestingButton.IsDisplayed();
                case "HomeButton":
                    return HomeButton.IsDisplayed();
                case "ActiveHomeButton":
                    return ActiveHomeButton.IsDisplayed();
                case "FormButton":
                    return FormButton.IsDisplayed();
                case "ActiveFormButton":
                    return ActiveFormButton.IsDisplayed();
                case "ErrorButton":
                    return ErrorButton.IsDisplayed();
            }
            return false;
        }
    }
}