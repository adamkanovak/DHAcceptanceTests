using DHAcceptanceTests.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DHAcceptanceTests.PageObjects
{
    class HomePage
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.CssSelector, Using = "div[class=ui-test]>h1")]
        private IWebElement h1Text { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class=ui-test]>p")]
        private IWebElement pText { get; set; }

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public bool isDisplayed(string WebElementName)
        {
            switch (WebElementName)
            {
                case "h1Text":
                    return h1Text.IsDisplayed();
                case "pText":
                    return pText.IsDisplayed();
            }
            return false;
        }

        public string getTextOfElement(string WebElementName)
        {
            switch (WebElementName)
            {
                case "h1Text":
                    return h1Text.Text;
                case "pText":
                    return pText.Text;
            }
            return null;
        }
    }
}
