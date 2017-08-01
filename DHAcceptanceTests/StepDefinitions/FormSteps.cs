using DHAcceptanceTests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Assert.IsTrue(submittedFormPage.IsDisplayed("HelloText"));
        }

        [Then(@"the (.*) text should be displayed")]
        public void ThenTheTextShouldBeDisplayed(string expectedValue)
        {
            Assert.AreEqual(expectedValue, submittedFormPage.GetHelloText(), "Hello text on the Submitted form page is not correct");
        }

        [Then(@"one input box should be visible")]
        public void ThenOneInputBoxShouldBeVisible()
        {
            Assert.IsTrue(formPage.IsDisplayed("FormInputField"));
        }

        [Then(@"one submit button should be visible")]
        public void ThenOneSubmitButtonShouldBeVisible()
        {
            Assert.IsTrue(formPage.IsDisplayed("FormSubmitButton"));
        }
    }
}
