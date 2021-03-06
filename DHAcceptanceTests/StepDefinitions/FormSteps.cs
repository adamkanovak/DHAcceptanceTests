﻿using DHAcceptanceTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DHAcceptanceTests.StepDefinitions
{
    [Binding]
    class FormSteps
    {
        private IWebDriver _driver;
        private FormPage formPage;
        private SubmittedFormPage submittedFormPage;

        public FormSteps(IWebDriver driver, FormPage formPage, SubmittedFormPage submittedFormPage)
        {
            _driver = driver;
            this.formPage = formPage;
            this.submittedFormPage = submittedFormPage;
        }

        [When(@"the user types the (.*) into the input field")]
        public void WhenTheUserTypesTheIntoTheInputField(string value)
        {
            formPage.EnterTextToFormInputField(value);
        }

        [When(@"the user clicks the Go! button")]
        public void WhenTheUserClicksTheGoButton()
        {
            formPage.ClickGoButton();
        }

        [Then(@"the user should be redirected to the Hello page")]
        public void ThenTheUserShouldBeRedirectedToTheHelloPage()
        {
            Assert.IsTrue(submittedFormPage.IsDisplayed("HelloText"), "The user is not redirected to the HelloPage");
        }

        [Then(@"the (.*) text should be displayed")]
        public void ThenTheTextShouldBeDisplayed(string expectedValue)
        {
            Assert.AreEqual(expectedValue, submittedFormPage.GetHelloText(), "Hello text on the Submitted form page is not correct");
        }

        [Then(@"one input box should be visible")]
        public void ThenOneInputBoxShouldBeVisible()
        {
            Assert.IsTrue(formPage.IsDisplayed("FormInputField"), "The form page's input box is not displayed");
        }

        [Then(@"one submit button should be visible")]
        public void ThenOneSubmitButtonShouldBeVisible()
        {
            Assert.IsTrue(formPage.IsDisplayed("FormSubmitButton"), "The form page's Go! button is not displayed");
        }
    }
}
