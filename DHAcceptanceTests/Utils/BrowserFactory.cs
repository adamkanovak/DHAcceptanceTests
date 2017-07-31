using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace DHAcceptanceTests.Utils
{
    class BrowserFactory
    {
        private static IWebDriver Driver;

        /// <summary>
        /// Returns a new webDriver instance, or returns the existing one.
        /// Default one is Chrome.
        /// </summary>
        /// <param name="browserName"></param>
        /// <returns></returns>
        public static IWebDriver GetDriver()
        {
            switch (ConfigurationManager.AppSettings["Browser"])
            {
                case "Chrome":
                    if (Driver == null)
                    {
                        Driver = new ChromeDriver();
                        Driver.Manage().Window.Maximize();
                        Driver.Url = ConfigurationManager.AppSettings["BaseUrl"];
                    }
                    break;
            }         
            return Driver;
        }
        /// <summary>
        /// Destroys the existing webDriver instance. 
        /// </summary>
        public static void DestroyDriver()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}