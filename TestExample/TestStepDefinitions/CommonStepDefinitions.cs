using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestExample.PageDefinitions;
using TestExample.Setup;

namespace TestExample.TestStepDefinitions
{
    [Binding]
    public class CommonStepDefinitions : TestStepDefinitionBase
    {
        [BeforeScenario]
        public void Setup()
        {
            SecurityPageDefinition.GoToMainPage();

            try
            {
                SecurityPageDefinition.SecurityAdvancedButton.Click();
                SecurityPageDefinition.SecurityProceedLink.Click();
            }
            catch (NoSuchElementException)
            {
                //report security page skipped
            }
        }

        [AfterFeature]
        public static void FeatureTeardown()
        {
            Webdriver.GetDriver().Dispose();
        }

    }
}
