using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Components;

namespace MagentoLv553SET.Pages
{
    class AuthorizationPage : AMenuPart
    {
        public AuthorizationPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement EmailField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(AuthorizationPageMap.emailField));
                return driver.FindElement(AuthorizationPageMap.emailField);
            }
        }
        public IWebElement PasswordField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(AuthorizationPageMap.passwordField));
                return driver.FindElement(AuthorizationPageMap.passwordField);
            }
        }
        public IWebElement SignInButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(AuthorizationPageMap.signInButton));
                return driver.FindElement(AuthorizationPageMap.signInButton);
            }
        }

        

    }
}
