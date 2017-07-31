using DHAcceptanceTests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DHAcceptanceTests.StepDefinitions
{
    [Binding]
    class NavigationSteps
    {
        [Given(@"the user is navigated to the site")]
        public void GivenTheUserIsNavigatedToTheSite()
        {
            Assert.True(Page.Header.IsDisplayed("HomeButton"), "The application is not loaded");
        }

        [When(@"the user clicks the home button")]
        public void WhenTheUserClicksTheHomeButton()
        {
            Page.Header.ClickHomeButton();
        }
        
        [Then(@"the user should be navigated to the Home page")]
        public void ThenTheUserShouldBeNavigatedToTheHomePage()
        {
            Assert.True(Page.Home.IsDisplayed("WelcomeText"), "The user is not on the Home Page");
        }
    }
}
