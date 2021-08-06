using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest.SeleniumUtils.Wrappers
{
    internal class WebDriverFactory
    {
        public virtual IWebDriver CreatedLocalChromeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);
            return new ChromeDriver(options);
        }


    }
}
