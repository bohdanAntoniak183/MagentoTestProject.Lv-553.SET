using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumPageObject.Maps;
using SeleniumPageObject.Components;

namespace SeleniumPageObject.Pages
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
