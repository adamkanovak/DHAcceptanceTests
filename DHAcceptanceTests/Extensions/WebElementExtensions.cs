using OpenQA.Selenium;
using System;

namespace DHAcceptanceTests.Extensions
{
    public static class WebElementExtensions
    {
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
