using OpenQA.Selenium;
using TestExample.Setup;

namespace TestExample.PageDefinitions
{
    public class SecurityPageDefinition : PageDefinitionBase
    {
        public SecurityPageDefinition(IWebDriver webDriver) : base(webDriver) { }

        public IWebElement SecurityAdvancedButton
        {
            get => _driver.FindElement(By.Id("details-button"));
        }

        public IWebElement SecurityProceedLink
        {
            get => _driver.FindElement(By.Id("proceed-link"));
        }
    }
}
