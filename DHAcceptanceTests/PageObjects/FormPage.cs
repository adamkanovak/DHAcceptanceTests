using DHAcceptanceTests.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace DHAcceptanceTests.PageObjects
{
    class FormPage
    {
        private readonly IWebDriver _driver;
        private WebDriverWait wait;

        [FindsBy(How = How.Id, Using = "hello-input")]
        private IWebElement FormInputField { get; set; }

        [FindsBy(How = How.Id, Using = "hello-submit")]
        private IWebElement FormSubmitButton { get; set; }

        public FormPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
        }

        public FormPage EnterTextToFormInputField(string text)
        {
            wait.Until(driver => FormInputField.IsDisplayed());
            FormInputField.SendKeys(text);
            return this;
        }

        public FormPage ClickGoButton()
        {
            wait.Until(driver => FormSubmitButton.IsDisplayed());
            FormSubmitButton.Click();
            return this;
        }

        public bool IsDisplayed(string WebElementName)
        {
            wait.Until(driver => FormInputField.IsDisplayed());
            switch (WebElementName)
            {
                case "FormInputField":
                    return FormInputField.IsDisplayed();
                case "FormSubmitButton":
                    return FormSubmitButton.IsDisplayed();
            }
            return false;
        }
    }
}
