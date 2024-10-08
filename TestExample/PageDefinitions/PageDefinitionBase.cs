using OpenQA.Selenium;
using TestExample.Setup;

namespace TestExample.PageDefinitions
{
    public class PageDefinitionBase
    {
        protected Config _config;
        protected IWebDriver _driver;

        public PageDefinitionBase(IWebDriver webdriver)
        {
            _driver = webdriver;
            _config = new Config();
            _config.ReadJson();
        }

        public void GoToMainPage()
        {
            _driver.Navigate().GoToUrl(_config.PATH);
        }

        public IWebElement WaitFor(IWebElement element, int miliseconds)
        {
            NoSuchElementException ex = null;

            for (int i = 0; i <= miliseconds; i+= 300)
            { 
                try
                {
                    var isDisplayed = element.Displayed;
                    return element;
                }
                catch (NoSuchElementException exception)
                {
                    ex = exception;
                }
            }

            throw ex;
        }
    }
}