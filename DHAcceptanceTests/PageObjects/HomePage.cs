using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DHAcceptanceTests.PageObjects
{
   public class HomePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/h1")]
        private IWebElement WelcomeText { get; set; }

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
