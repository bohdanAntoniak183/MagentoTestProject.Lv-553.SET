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
        public IWebElement WelcomeMessage => new PropertyGetters(driver).GetVisibleWebElement(SuccessfulLoginPageMap.welcomeMessage);
        
        public IWebElement MyAccountTitle => new PropertyGetters(driver).GetVisibleWebElement(SuccessfulRegistrationPageMap.myAccountTitle);
        
        public IWebElement ChangePasswordLink=> new PropertyGetters(driver).GetClickableWebElement(SuccessfulRegistrationPageMap.changePasswordLink);

        public IWebElement SuccessfulSaveInformationMessage => new PropertyGetters(driver).GetVisibleWebElement(SuccessfulRegistrationPageMap.successSaveMessage);
    }
}
