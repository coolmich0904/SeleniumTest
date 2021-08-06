using System;
using OpenQA.Selenium;
using SeleniumTest.SeleniumUtils.Wrappers;

namespace SeleniumTest.SeleniumUtils
{
    class LocalDriverBuilder
    {
        private readonly WebDriverFactory factory;
        internal LocalDriverBuilder(WebDriverFactory factory)
        {
            this.factory = factory;
        }

        public virtual IWebDriver Launch(string browserTarget, string startingUrl)
        {
            var driver = CreateWebDriver(browserTarget);
            driver.Navigate().GoToUrl(startingUrl);
            return driver;
        }

        private IWebDriver CreateWebDriver(string browserTarget)
        {

            switch (browserTarget)
            {
                case BrowserTarget.Chrome:
                    return factory.CreatedLocalChromeDriver();
                default:
                    throw new NotSupportedException($"{browserTarget} is not supported local browser type.");
            }
        }

    }
}
