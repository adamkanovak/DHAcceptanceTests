﻿using DHAcceptanceTests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DHAcceptanceTests.StepDefinitions
{
    [Binding]
    class ErrorPageSteps
    {
        [Given(@"the user is navigated to the site")]
        public void GivenTheUserIsNavigatedToTheSite()
        {
            Assert.True(Page.Header.IsDisplayed("HomeButton"), "The application is not loaded");
        }
        
        [When(@"the user clicks the Error button in the header")]
        public void WhenTheUserClicksTheErrorButtonInTheHeader()
        {
            Page.Header.ClickErrorButton();
        }

        [Then(@"the user should be navigated to Error page (.*)")]
        public void ThenTheUserShouldBeNavigatedToErrorPage(int p0)
        {
            Assert.AreEqual(p0 + " Error: File not found :-)", Page.GetPageTitle(), "The user is not navigated to Error page " +p0);
        }
    }
}