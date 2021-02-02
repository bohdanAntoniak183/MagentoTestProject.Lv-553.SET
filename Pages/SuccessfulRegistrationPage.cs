using OpenQA.Selenium;
using SeleniumPageObject.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumPageObject.Pages
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
