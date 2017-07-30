using DHAcceptanceTests.Utils;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace DHAcceptanceTests.PageObjects
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.GetDriver(), page);
            return page;
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static Header Header
        {
            get { return GetPage<Header>(); }
        }

        public static String GetPageTitle()
        {
            return BrowserFactory.GetDriver().Title;
        }
    }
}
