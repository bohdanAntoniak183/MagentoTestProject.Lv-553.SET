using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Components;

namespace MagentoLv553SET.Pages
{
    class SuccessfulLoginPage : BasePage
    {
        public SuccessfulLoginPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement WelcomeMessage
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(SuccessfulLoginPageMap.welcomeMessage));
                return driver.FindElement(SuccessfulLoginPageMap.welcomeMessage);
            }
        }
    }
}
