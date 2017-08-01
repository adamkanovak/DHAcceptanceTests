using BoDi;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DHAcceptanceTests.Utils
{
    [Binding]
    class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void SetUp()
        {
            BrowserFactory browserFactory = new BrowserFactory();
            _driver = browserFactory.Driver;
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.Dispose();
        }
    }
}