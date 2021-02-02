using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Pages;
using OpenQA.Selenium.Interactions;

namespace MagentoLv553SET.Steps
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

        public ProductPageBL ClickOnProductContainer()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(successfulLoginPage.MainPageProductContainer).Build().Perform();
            successfulLoginPage.MainPageProductContainer.Click();
            return new ProductPageBL(webDriver);
        }
    }
}
