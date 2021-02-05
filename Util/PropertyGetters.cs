using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;

namespace MagentoLv553SET.Util
{
    class PropertyGetters : BasePage
    {
        public PropertyGetters(IWebDriver webDriver) : base(webDriver)
        {
        }
        public IWebElement GetVisibleWebElement(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }
        public IWebElement GetClickableWebElement(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.ElementToBeClickable(locator));
            return driver.FindElement(locator);
        }
    }
}
