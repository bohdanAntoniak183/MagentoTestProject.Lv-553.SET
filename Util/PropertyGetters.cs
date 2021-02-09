<<<<<<< HEAD
﻿using OpenQA.Selenium;
using MagentoLv553SET.Pages;
=======
using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
>>>>>>> master
using System.Collections.Generic;

namespace MagentoLv553SET.Util
{
    public class PropertyGetters : BasePage
    {
        public PropertyGetters(IWebDriver webDriver) : base(webDriver)
        {
<<<<<<< HEAD

=======
>>>>>>> master
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

        public IList<IWebElement> GetWebElements(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.
                ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
            return driver.FindElements(locator);
        }
    }

}

