﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHAcceptanceTests.PageObjects
{
    public class Footer
    {
        private readonly IWebDriver _driver;
        private WebDriverWait wait;

        [FindsBy(How = How.Id, Using = "site")]
        private IWebElement CompanyLogo { get; set; }

        public Footer(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(1));
        }

        public bool IsDisplayed(string WebElementName)
        {
            switch (WebElementName)
            {
                case "CompanyLogo":
                    try
                    {
                        return CompanyLogo.Displayed;
                    }
                    catch (Exception)
                    {

                        return false;
                    }
            }
            return false;
        }
    }
}