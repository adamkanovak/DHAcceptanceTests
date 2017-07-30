using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace DHAcceptanceTests.PageObjects
{
    public class Header
    {
        [FindsBy(How = How.Id, Using = "home")]
        private IWebElement HomeButton { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        private IWebElement FormButton { get; set; }

        [FindsBy(How = How.Id, Using = "error")]
        private IWebElement ErrorButton { get; set; }

        public Header ClickHomeButton()
        {
            HomeButton.Click();
            return this;
        }

        public Header ClickFormButton()
        {
            FormButton.Click();
            return this;
        }

        public Header ClickErrorButton()
        {
            ErrorButton.Click();
            return this;
        }

        public bool IsDisplayed(String WebElementName)
        {
            switch(WebElementName)
            {
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