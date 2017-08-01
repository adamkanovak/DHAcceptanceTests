using DHAcceptanceTests.PageObjects;
using DHAcceptanceTests.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DHAcceptanceTests.StepDefinitions
{
    [Binding]
    class ErrorPageSteps
    {
        private readonly IWebDriver _driver;
        private readonly Header header;

        public ErrorPageSteps(IWebDriver driver, Header header)
        {
            _driver = driver;
            this.header = header;
        }

        [When(@"the user clicks the Error button in the header")]
        public void WhenTheUserClicksTheErrorButtonInTheHeader()
        {
            header.ClickErrorButton();
        }

        [Then(@"the user should be navigated to Error page (.*)")]
        public void ThenTheUserShouldBeNavigatedToErrorPage(int p0)
        {
            Assert.AreEqual(p0 + " Error: File not found :-)", _driver.Title, "The user is not navigated to Error page " + p0);
        }
    }
}
