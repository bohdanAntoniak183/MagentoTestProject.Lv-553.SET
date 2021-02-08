using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using MagentoLv553SET.Components;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Pages
{
    class HomePage : AMenuPart
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public IWebElement MainSignInButton => new PropertyGetters(driver).GetVisibleWebElement(HomePageMap.mainSignInButton);

        public IWebElement CreateAnAccountButton => new PropertyGetters(driver).GetClickableWebElement(HomePageMap.createAnAccountButton);

        
    }
}
