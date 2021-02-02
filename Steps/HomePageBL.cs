using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Pages;

namespace MagentoLv553SET.Steps
{
    class HomePageBL
    {
        private readonly HomePage homePage;
        protected IWebDriver webDriver;

        public HomePageBL(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            homePage = new HomePage(webDriver);
        }

        public AuthorizationPageBL ClickOnMainSignInButton()
        {
            homePage.MainSignInButton.Click();
            return new AuthorizationPageBL(webDriver);
        }
    }
}
