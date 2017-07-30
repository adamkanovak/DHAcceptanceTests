using TechTalk.SpecFlow;

namespace DHAcceptanceTests.Utils
{
    [Binding]
    class Hooks
    {

        [BeforeTestRun]
        public static void SetUp()
        {
            BrowserFactory.GetDriver("Chrome");         
        }

        [AfterTestRun]
        public static void TearDown()
        {
            BrowserFactory.DestroyDriver();
        }
    }
}