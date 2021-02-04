using MagentoLv553SET.Components;
using MagentoLv553SET.Data;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;
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
        public IWebElement FirstNameField => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.firstNameField, driver);
        public IWebElement LastNameField => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.lastNameField, driver);
        public IWebElement SignUpForNewslettersCheckbox => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.signUpForNewslettersCheckbox, driver);
        public IWebElement EmailAddressField => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.emailAddressField, driver);

        public IWebElement PasswordField => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.passwordField, driver);

        public IWebElement ConfirmPasswordField => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.confirmPasswordField, driver);
        public IWebElement SubmitRegistrationButton => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.submitRegistrationButton, driver);

        
        
        public IWebElement FirstNameEmptyFieldErrorMessage => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.firstNameEmptyFieldErrorMessage, driver);
        public IWebElement LastNameEmptyFieldErrorMessage => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.lastNameEmptyFieldErrorMessage, driver);
        public IWebElement NewUserEmailEmptyFieldErrorMessage => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.newUserEmailEmptyFieldErrorMessage, driver);
        public IWebElement NewUserPasswordEmptyFieldErrorMessage => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.newUserPasswordEmptyFieldErrorMessage, driver);
        public IWebElement NewUserConfirmPasswordEmptyFieldErrorMessage => PropertyGetters.
            GetVisibleWebElement(RegistrationPageMap.newUserConfirmPasswordEmptyFieldErrorMessage, driver);                

    }
}
