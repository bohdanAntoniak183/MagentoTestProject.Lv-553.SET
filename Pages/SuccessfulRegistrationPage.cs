using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
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
        
        public IWebElement MyAccountTitle
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(SuccessfulRegistrationPageMap.myAccountTitle));
                return driver.FindElement(SuccessfulRegistrationPageMap.myAccountTitle);
            }
        }
        public IWebElement ChangePasswordLink
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(SuccessfulRegistrationPageMap.changePasswordLink));
                return driver.FindElement(SuccessfulRegistrationPageMap.changePasswordLink);
            }
        }
        
    }
}
