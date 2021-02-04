using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Pages
{
    class SuccessfulRegistrationPage : AMenuPart
    {
        public SuccessfulRegistrationPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement WelcomeMessage => PropertyGetters.
            GetVisibleWebElement(SuccessfulLoginPageMap.welcomeMessage,driver);
        
        public IWebElement MyAccountTitle => PropertyGetters.
            GetVisibleWebElement(SuccessfulRegistrationPageMap.myAccountTitle, driver);
        
        public IWebElement ChangePasswordLink=> PropertyGetters.
            GetClickableWebElement(SuccessfulRegistrationPageMap.changePasswordLink,driver);        

    }
}
