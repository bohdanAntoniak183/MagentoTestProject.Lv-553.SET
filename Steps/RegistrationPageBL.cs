using MagentoLv553SET.Data;
using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Steps
{
    class RegistrationPageBL : HomePageBL
    {
        private readonly RegistrationPage registrationPage;
        private static readonly string randomPassword = TestsDataGenerator.GenerateRandomPassword(10);
        private static readonly int randomUserNameLength = 8;
        private static readonly int randomUserLastNameLength = 12;
        private static readonly int randomUserEmailLength = 7; 


        public RegistrationPageBL(IWebDriver webDriver) : base(webDriver)
        {
            registrationPage = new RegistrationPage(webDriver);
        }
        public SuccessfulRegistrationPageBL CreateAnAccount()
        {
            InputNewUserFirstName();
            InputNewUserLastName();
            InputNewUserEmail();
            InputNewUserPassword();
            InputNewUserConfirmationPassword();
            ClickOnSubmitRegistrationButton();

            return new SuccessfulRegistrationPageBL(webDriver);
        }
        public RegistrationPageBL TryToCreateAnAccountWithEmptyFields()
        {
            InputEmptyNewUserFirstName();
            InputEmptyNewUserLastName();
            InputEmptyNewUserEmail();
            InputEmptyNewUserPassword();
            InputEmptyNewUserConfirmPassword();
            ClickOnSubmitRegistrationButton();

            return this; 
        }
        private void InputNewUserFirstName()
        {
            registrationPage.FirstNameField.Clear();
            registrationPage.FirstNameField.SendKeys(TestsDataGenerator.GenerateRandomUserName(randomUserNameLength,true));
        }
        private void InputNewUserLastName()
        {
            registrationPage.LastNameField.Clear();
            registrationPage.LastNameField.SendKeys(TestsDataGenerator.GenerateRandomUserName(randomUserLastNameLength, true));
        }
        private void InputNewUserEmail()
        {
            registrationPage.EmailAddressField.Clear();
            registrationPage.EmailAddressField.SendKeys(TestsDataGenerator.GenerateRandomEmail(DomenName.UkrNet, randomUserEmailLength));
        }

        private void InputNewUserPassword()
        {
            registrationPage.PasswordField.Clear();
            registrationPage.PasswordField.SendKeys(randomPassword);

        }
        private void InputNewUserConfirmationPassword()
        {
            registrationPage.ConfirmPasswordField.Clear();
            registrationPage.ConfirmPasswordField.SendKeys(randomPassword);
        }
        private void ClickOnSubmitRegistrationButton()
        {
            registrationPage.SubmitRegistrationButton.Click();
        }
        private void InputEmptyNewUserFirstName()
        {
            registrationPage.FirstNameField.Clear();
            registrationPage.FirstNameField.SendKeys("");
        }
        private void InputEmptyNewUserLastName()
        {
            registrationPage.LastNameField.Clear();
            registrationPage.LastNameField.SendKeys("");
        }
        private void InputEmptyNewUserEmail()
        {
            registrationPage.EmailAddressField.Clear();
            registrationPage.EmailAddressField.SendKeys("");
        }
        private void InputEmptyNewUserPassword()
        {
            registrationPage.PasswordField.Clear();
            registrationPage.PasswordField.SendKeys("");
        }
        private void InputEmptyNewUserConfirmPassword()
        {
            registrationPage.ConfirmPasswordField.Clear();
            registrationPage.ConfirmPasswordField.SendKeys("");
        }
        public string GetErrorMessage()
        {
            string errorMessage = registrationPage.FirstNameEmptyFieldErrorMessage.Text;
            return errorMessage;
        }

    }
}
