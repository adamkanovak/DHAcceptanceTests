using DHAcceptanceTests.PageObjects;
using DHAcceptanceTests.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DHAcceptanceTests.StepDefinitions
{
    [Binding]
    class NavigationSteps
    {
        private IWebDriver _driver;
        private Header header;
        private HomePage homePage;


        public NavigationSteps(IWebDriver driver, Header header, HomePage homePage)
        {
            driver = _driver;
            this.header = header;
            this.homePage = homePage;
        }

        [Given(@"the user is navigated to the site")]
        public void GivenTheUserIsNavigatedToTheSite()
        {
            Assert.True(header.IsDisplayed("HomeButton"), "The application is not loaded");
        }

        [When(@"the user clicks the home button")]
        public void WhenTheUserClicksTheHomeButton()
        {
            header.ClickHomeButton();
        }

        [Then(@"the user should be navigated to the Home page")]
        public void ThenTheUserShouldBeNavigatedToTheHomePage()
        {
            Assert.True(homePage.IsDisplayed("WelcomeText"), "The user is not on the Home Page");
        }
    }
}
