using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using MagentoLv553SET.Components;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Pages
{
    class HomePage : AMenuPart
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement MainSignInButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(HomePageMap.mainSignInButton));
                return driver.FindElement(HomePageMap.mainSignInButton);
            }
        }

        public IWebElement FusionBackPackProduct
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(HomePageMap.fusionBackpackProduct));
                return driver.FindElement(HomePageMap.fusionBackpackProduct);
            }
        }

        public IWebElement AddToWishListButtonforFusionBackpackProduct
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(HomePageMap.addToWishListButtonforFusionBackpackProduct));
                return driver.FindElement(HomePageMap.addToWishListButtonforFusionBackpackProduct);
            }
        }

        public IWebElement AddToWishListButtonforPushItMessengerBagProduct
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(HomePageMap.addToWishListButtonforPushItMessengerBagProduct));
                return driver.FindElement(HomePageMap.addToWishListButtonforPushItMessengerBagProduct);
            }
        }

        public void ClickOnMainSignInButton() 
        {
            MainSignInButton.Click();
        }

        public void ClickOnFusionBackPackProduct()
        {
            FusionBackPackProduct.Click();
        }

        public void ClickOnAddToWishListButtonforFusionBackpackProduct()
        {
            AddToWishListButtonforFusionBackpackProduct.Click();
        }

        public void ClickOnAddToWishListButtonforPushItMessengerBagProduct()
        {
            AddToWishListButtonforPushItMessengerBagProduct.Click();
        }









    }
}
