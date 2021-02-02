using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Pages
{
    class RegistrationPage : AMenuPart
    {
        public RegistrationPage(IWebDriver webDriver) : base(webDriver)
        {

        }


        public IWebElement CreateNewCustomerAccountTitle
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(RegistrationPageMap.createNewCustomerAccountTitle));
                return driver.FindElement(RegistrationPageMap.createNewCustomerAccountTitle);
            }
        }
        public IWebElement FirstNameField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(RegistrationPageMap.firstNameField));
                return driver.FindElement(RegistrationPageMap.firstNameField);
            }
        }
        public IWebElement LastNameField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(RegistrationPageMap.lastNameField));
                return driver.FindElement(RegistrationPageMap.lastNameField);
            }
        }
        public IWebElement SignUpForNewslettersCheckbox
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(RegistrationPageMap.signUpForNewslettersCheckbox));
                return driver.FindElement(RegistrationPageMap.signUpForNewslettersCheckbox);
            }
        }
        public IWebElement EmailAddressField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(RegistrationPageMap.emailAddressField));
                return driver.FindElement(RegistrationPageMap.emailAddressField);
            }
        }

        public IWebElement PasswordField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(RegistrationPageMap.passwordField));
                return driver.FindElement(RegistrationPageMap.passwordField);
            }
        }
        public IWebElement ConfirmPasswordField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(RegistrationPageMap.confirmPasswordField));
                return driver.FindElement(RegistrationPageMap.confirmPasswordField);
            }
        }
        public IWebElement SubmitRegistration
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(RegistrationPageMap.submitRegistration));
                return driver.FindElement(RegistrationPageMap.submitRegistration);
            }
        }
    }
}
