using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Util
{
    class PropertyGetters 

    {
        private static WebDriverWait wait;

        private static void SetWait(IWebDriver driver)
        {
            wait = new WebDriverWait(driver, new System.TimeSpan(10));
        }

        public static IWebElement GetClickableWebElement(By locator, IWebDriver driver)
        {
            SetWait(driver);

            wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(locator));
            return driver.FindElement(locator);
        }

        public static IWebElement GetVisibleWebElement(By locator, IWebDriver driver)
        {
            SetWait(driver);

            wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }
    }
}
