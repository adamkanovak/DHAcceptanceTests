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
        private FormPage formPage;


        public NavigationSteps(IWebDriver driver, Header header, HomePage homePage, FormPage formPage)
        {
            _driver = driver;
            this.header = header;
            this.homePage = homePage;
            this.formPage = formPage;
        }

        [Given(@"the user is navigated to the site")]
        public void GivenTheUserIsNavigatedToTheSite()
        {
            Assert.True(header.IsDisplayed("HomeButton"), "The application is not loaded");
        }

        [When(@"the user clicks the ([^ ]*) button in the header")]
        public void WhenTheUserClicksOneButtonInTheHeader(string buttonName)
        {
            switch (buttonName.ToLower())
            {
                case "home":
                    header.ClickHomeButton();
                    break;
                case "form":
                    header.ClickFormButton();
                    break;
                case "error":
                    header.ClickErrorButton();
                    break;
            }
        }

        [Then(@"the user should be navigated to the Home page")]
        public void ThenTheUserShouldBeNavigatedToTheHomePage()
        {
            Assert.True(homePage.IsDisplayed("WelcomeText"), "The user is not on the Home Page");
        }

        [Then(@"the user should be navigated to the Form page")]
        public void ThenTheUserShouldBeNavigatedToTheFormPage()
        {
            Assert.True(formPage.IsDisplayed("FormInputField"), "The user is not on the Form Page");
        }

        [Then(@"the user should be navigated to Error page (.*)")]
        public void ThenTheUserShouldBeNavigatedToErrorPage(int p0)
        {
            Assert.AreEqual(p0 + " Error: File not found :-)", _driver.Title, "The user is not navigated to Error page " + p0);
        }
    }
}
