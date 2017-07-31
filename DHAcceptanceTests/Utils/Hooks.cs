using TechTalk.SpecFlow;

namespace DHAcceptanceTests.Utils
{
    [Binding]
    class Hooks
    {

        [BeforeTestRun]
        public static void SetUp()
        {
            BrowserFactory.GetDriver();         
        }

        [AfterTestRun]
        public static void TearDown()
        {
            BrowserFactory.DestroyDriver();
        }
    }
}