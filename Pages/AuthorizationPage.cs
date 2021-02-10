using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Components;
using MagentoLv553SET.Util;
using MagentoLv553SET.Data;

namespace MagentoLv553SET.Pages
{
    class AuthorizationPage : AMenuPart
    {
        public AuthorizationPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement EmailField => new PropertyGetters(driver).
            GetVisibleWebElement(AuthorizationPageMap.emailField);


        public IWebElement PasswordField => new PropertyGetters(driver).
            GetVisibleWebElement(AuthorizationPageMap.passwordField);

        public IWebElement SignInButton => new PropertyGetters(driver).
            GetVisibleWebElement(AuthorizationPageMap.signInButton);
    }
}
