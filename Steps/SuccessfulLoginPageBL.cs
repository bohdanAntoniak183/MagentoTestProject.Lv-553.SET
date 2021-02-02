using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumPageObject.Pages;

namespace SeleniumPageObject.Steps
{
    class SuccessfulLoginPageBL : HomePageBL
    {
        private readonly SuccessfulLoginPage successfulLoginPage;

        public SuccessfulLoginPageBL(IWebDriver webDriver) : base(webDriver)
        {
            successfulLoginPage = new SuccessfulLoginPage(webDriver);
        }

        public string GetWelcomeMessage()
        {
            string welcomeMessage = successfulLoginPage.WelcomeMessage.Text;
            return welcomeMessage;
        }
    }
}
