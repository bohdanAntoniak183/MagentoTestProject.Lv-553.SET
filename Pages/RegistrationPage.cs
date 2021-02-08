using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;
using OpenQA.Selenium;

namespace MagentoLv553SET.Pages
{
    class RegistrationPage : AMenuPart

    {
        public RegistrationPage(IWebDriver webDriver) : base(webDriver)
        {

        }        
        public IWebElement FirstNameField => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.firstNameField);
        public IWebElement LastNameField => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.lastNameField);
        public IWebElement SignUpForNewslettersCheckbox => new PropertyGetters(driver).GetClickableWebElement(RegistrationPageMap.signUpForNewslettersCheckbox);
        public IWebElement EmailAddressField => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.emailAddressField);

        public IWebElement PasswordField => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.passwordField);
        public IWebElement ConfirmPasswordField => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.confirmPasswordField);
        public IWebElement SubmitRegistrationButton => new PropertyGetters(driver).GetClickableWebElement(RegistrationPageMap.submitRegistrationButton);
                
        public IWebElement FirstNameEmptyFieldErrorMessage => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.firstNameEmptyFieldErrorMessage);
        public IWebElement LastNameEmptyFieldErrorMessage => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.lastNameEmptyFieldErrorMessage);
        public IWebElement NewUserEmailEmptyFieldErrorMessage => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.newUserEmailEmptyFieldErrorMessage);
        public IWebElement NewUserPasswordEmptyFieldErrorMessage => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.newUserPasswordEmptyFieldErrorMessage);
        public IWebElement NewUserConfirmPasswordEmptyFieldErrorMessage => new PropertyGetters(driver).GetVisibleWebElement(RegistrationPageMap.newUserConfirmPasswordEmptyFieldErrorMessage);                

    }
}
