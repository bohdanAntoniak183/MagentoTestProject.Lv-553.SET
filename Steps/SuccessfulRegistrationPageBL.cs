using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Steps
{
    class SuccessfulRegistrationPageBL : HomePageBL
    {
        private readonly SuccessfulRegistrationPage successfulRegistrationPage;

        public SuccessfulRegistrationPageBL(IWebDriver webDriver) : base(webDriver)
        {
            successfulRegistrationPage = new SuccessfulRegistrationPage(webDriver);
        }

        public string GetWelcomeMessage()
        {
            string welcomeMessage = successfulRegistrationPage.WelcomeMessage.Text;
            return welcomeMessage;
        }
        public string GetMyAccountTitle()
        {
            string myAccountTitle = successfulRegistrationPage.MyAccountTitle.Text;
            return myAccountTitle;
        }
        
    }
}
