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
    public class FormPage
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
            wait.Until(driver => FormInputField.Displayed);
            FormInputField.SendKeys(text);
            return this;
        }

        public FormPage ClickGoButton()
        {
            wait.Until(driver => FormSubmitButton.Displayed);
            FormSubmitButton.Click();
            return this;
        }

        public bool IsDisplayed(string WebElementName)
        {
            wait.Until(driver => FormInputField.Displayed);
            switch (WebElementName)
            {
                case "FormInputField":
                    return FormInputField.Displayed;
                case "FormSubmitButton":
                    return FormSubmitButton.Displayed;
            }
            return false;
        }
    }
}
