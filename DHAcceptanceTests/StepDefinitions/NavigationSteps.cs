using DHAcceptanceTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;
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
        private Footer footer;


        public NavigationSteps(IWebDriver driver, Header header, HomePage homePage, FormPage formPage, Footer footer)
        {
            _driver = driver;
            this.header = header;
            this.homePage = homePage;
            this.formPage = formPage;
            this.footer = footer;
        }

        [Given(@"the user is navigated to the site")]
        public void GivenTheUserIsNavigatedToTheSite()
        {
            _driver.Url = ConfigurationManager.AppSettings["BaseUrl"];
            Assert.True(header.IsDisplayed("HomeButton"), "The application is not loaded");
        }

        [When(@"the user is on the ([^ ]*) page")]
        [When(@"the user clicks the ([^ ]*) button in the header")]
        public void WhenTheUserClicksOneButtonInTheHeader(string buttonName)
        {
            switch (buttonName.ToLower())
            {
                case "uitestingbutton":
                    header.ClickUItestingButton();
                    break;
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
            Assert.True(homePage.isDisplayed("h1Text"), "The user is not on the Home Page");
        }

        [Then(@"the user should be navigated to the Form page")]
        public void ThenTheUserShouldBeNavigatedToTheFormPage()
        {
            Assert.True(formPage.IsDisplayed("FormInputField"), "The user is not on the Form Page");
        }

        [Then(@"the user should be navigated to Error page (.*)")]
        public void ThenTheUserShouldBeNavigatedToErrorPage(int ErrorPageCode)
        {
            Assert.AreEqual(ErrorPageCode + " Error: File not found :-)", _driver.Title, "The user is not navigated to Error page " + ErrorPageCode);
        }

        [Then(@"the page title should be (.*)")]
        public void ThenThePageTitleShouldBe(string pageTitle)
        {
            Assert.AreEqual(pageTitle, _driver.Title, "The page title is: " + _driver.Title + " instead of: " + pageTitle);
        }

        [Then(@"the company logo should be displayed")]
        public void ThenTheCompanyLogoShouldBeDisplayed()
        {
            Assert.True(footer.IsDisplayed("CompanyLogo"), "The company logo is not displayed");
        }
    }
}
