using DHAcceptanceTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DHAcceptanceTests.StepDefinitions
{
    [Binding]
    class HomePageSteps
    {
        private IWebDriver _driver;
        private HomePage homePage;

        public HomePageSteps(IWebDriver driver, HomePage homePage)
        {
            _driver = driver;
            this.homePage = homePage;
        }

        [Then(@"the ""(.*)"" text should be displayed in h1 tag")]
        public void ThenTheTextShouldBeDisplayedInHTag(string expectedText)
        {
            Assert.AreEqual(expectedText, homePage.getTextOfElement("h1Text"));
        }

        [Then(@"the ""(.*)"" text should be displayed in p tag")]
        public void ThenTheTextShouldBeDisplayedInPTag(string expectedText)
        {
            Assert.AreEqual(expectedText, homePage.getTextOfElement("pText"));
        }
    }
}
