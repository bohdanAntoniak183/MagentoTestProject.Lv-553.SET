using System;
using System.Collections.Generic;
using System.Text;
using SeleniumPageObject.Pages;
using SeleniumPageObject.Data;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumPageObject.Steps
{
    class AuthorizationPageBL : HomePageBL
    {
        private readonly AuthorizationPage authorizationPage;
        public AuthorizationPageBL(IWebDriver webDriver) : base(webDriver)
        {
            authorizationPage = new AuthorizationPage(webDriver);
        }

        public SuccessfulLoginPageBL LogIntoAccount()
        {
            InputUserEmail();
            InputUserPassword();
            ClickOnSignInButton();

            return new SuccessfulLoginPageBL(webDriver);
        }

        private void InputUserEmail()
        {
            authorizationPage.EmailField.Clear();
            authorizationPage.EmailField.SendKeys(TestsData.logInEmail);
        }

        private void InputUserPassword()
        {
            authorizationPage.PasswordField.Clear();
            authorizationPage.PasswordField.SendKeys(TestsData.logInPassword);
        }
        private void ClickOnSignInButton()
        {
            authorizationPage.SignInButton.Click();
        }
    }
}
