using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace DHAcceptanceTests.Utils
{
    class BrowserFactory : IDisposable
    {
        private IWebDriver driver;

        /// <summary>
        /// Returns a new webDriver instance, or returns the existing one.
        /// Default one is Chrome.
        /// </summary>
        /// <param name="browserName"></param>
        /// <returns></returns>
        public IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    CreateWebDriver();
                return driver;
            }
        }
        private void CreateWebDriver()
        {
            switch (ConfigurationManager.AppSettings["Browser"].ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                default:
                    throw new NullReferenceException("Uknown browsertype added in App.config, please add a valid browser: Chrome");
            }
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Destroys the existing webDriver instance. 
        /// </summary>
        public void Dispose()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}