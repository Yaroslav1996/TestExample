using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestExample.Setup;

namespace TestExample.PageDefinitions
{
    public class WorldPhenomenaPageDefinition : PageDefinitionBase
    {
        public WorldPhenomenaPageDefinition(IWebDriver webDriver) : base(webDriver) { }

        public IWebElement WorldPhenomenaTab
        {
            get => _driver.FindElements(By.ClassName("mat-tab-label-content")).First(e => e.Text.Contains("World Phenomena"));
        }
        public IWebElement ResourceTab(string tabName)
        {
            return _driver.FindElement(By.XPath($"//*[text()='{tabName}']"));
        }

        public IWebElement ResourcesBox
        {
            get => _driver.FindElement(By.ClassName("resources-list"));
        }

        public IEnumerable<IWebElement> Resources
        {
            get => _driver.FindElements(By.ClassName("resources-card-beta"));
        }

        public IWebElement Resource(string resourseName)
        {
            return _driver.FindElement(By.XPath($"//*[text()='{resourseName}']"));
        }

        public IWebElement CommunicationButton
        {
            get => _driver.FindElement(By.XPath("//*[contains(text(),'Communication')]"));
        }

        public string ResourceType(IWebElement resource)
        {
            return resource.FindElement(By.XPath("../../..//span[text()='Resource']/../span[@class='resource-type__subtitle ng-star-inserted']")).Text;
        }

        public int ScrollResourcesTo(string resource)
        {
            int tries = 1;
            ResourcesBox.Click();

            for (int time = 0; time < 5000; time+=300)
            {
                new Actions(_driver)
               .SendKeys(Keys.PageDown)
               .Perform();

                try
                {
                    var isDisplayed = Resource(resource).Displayed;
                    return tries;
                }
                catch (NoSuchElementException)
                {
                    tries++;
                }
            }

            return tries;
        }
    }
}
