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
            string welcomeMessage = successfulLoginPage.GetWelcomeMessage();
            return welcomeMessage;
        }

        public FusionBackPackPageBL ClickOnFucionBackPackButton()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(successfulLoginPage.FusionBackPackProduct).Build().Perform();
            successfulLoginPage.ClickOnFusionBackPackProduct();
            return new FusionBackPackPageBL(webDriver);
        }

        public WishListPageBL ClickOnAddToWishListButtonforFusionBackpackProduct()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(successfulLoginPage.AddToWishListButtonforFusionBackpackProduct).Build().Perform();
            successfulLoginPage.ClickOnAddToWishListButtonforFusionBackpackProduct();
            return new WishListPageBL(webDriver);
        }

        public WishListPageBL ClickOnAddToWishListButtonforPushItMessangerBagProduct()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(successfulLoginPage.AddToWishListButtonforPushItMessengerBagProduct).Build().Perform();
            successfulLoginPage.ClickOnAddToWishListButtonforPushItMessengerBagProduct();
            return new WishListPageBL(webDriver);
        }


    }
}
