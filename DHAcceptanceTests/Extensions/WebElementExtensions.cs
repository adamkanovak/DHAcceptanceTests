using OpenQA.Selenium;
using System;

namespace DHAcceptanceTests.Extensions
{
    public static class WebElementExtensions
    {
        /// <summary>
        /// Returns true if the WebElement is displayed
        /// </summary>
        /// <param name="element"></param>
        /// <returns>True or false</returns>
        public static bool IsDisplayed(this IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
