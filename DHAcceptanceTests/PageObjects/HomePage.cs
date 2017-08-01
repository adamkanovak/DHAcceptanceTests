using DHAcceptanceTests.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DHAcceptanceTests.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/h1")]
        private IWebElement WelcomeText { get; set; }

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public bool IsDisplayed(string WebElementName)
        {
            switch (WebElementName)
            {
                case "WelcomeText":
                    return WelcomeText.Displayed;
            }
            return false;
        }
    }
}
