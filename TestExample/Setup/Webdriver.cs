using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TestExample.Setup
{
    public static class Webdriver
    {
        private static IWebDriver? _driver = null;

        public static IWebDriver GetDriver()
        {
            if (_driver != null) return _driver;

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-search-engine-choice-screen");

            _driver = new ChromeDriver(options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return _driver;
        }
    }
}
