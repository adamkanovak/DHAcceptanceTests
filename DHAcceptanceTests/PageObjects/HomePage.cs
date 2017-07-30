using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DHAcceptanceTests.PageObjects
{
   public class HomePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/h1")]
        public IWebElement WelcomeText { get; set; }
    
    }
}
