using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using SeleniumPageObject.Components;
using SeleniumPageObject.Pages;
using SeleniumPageObject.Maps;

namespace SeleniumPageObject.Pages
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
    }
}
