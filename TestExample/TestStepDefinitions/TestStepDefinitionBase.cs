using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestExample.PageDefinitions;
using TestExample.Setup;

namespace TestExample.TestStepDefinitions
{
    [Binding]
    public class TestStepDefinitionBase
    {
        public TestStepDefinitionBase() 
        {
            _driver = Webdriver.GetDriver();
            SecurityPageDefinition = new SecurityPageDefinition(_driver);
            WorldPhenomenaPageDefinition = new WorldPhenomenaPageDefinition(_driver);
            ZasobyPubliczneStepDefinition = new ZasobyPubliczneStepDefinition(_driver);
        }

        protected IWebDriver _driver;

        protected SecurityPageDefinition SecurityPageDefinition { get; set; }
        protected WorldPhenomenaPageDefinition WorldPhenomenaPageDefinition { get; set; }
        protected ZasobyPubliczneStepDefinition ZasobyPubliczneStepDefinition { get; set; }
    }
}