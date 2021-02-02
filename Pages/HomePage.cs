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
    }
}
