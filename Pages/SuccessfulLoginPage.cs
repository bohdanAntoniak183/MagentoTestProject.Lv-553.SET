using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Components;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Pages
{
    class SuccessfulLoginPage : HomePage
    {
        public SuccessfulLoginPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement ComparisonListLink => new  PropertyGetters(driver).
            GetClickableWebElement(SuccessfulLoginPageMap.comparisonListLink);

        public IWebElement AddedProductMessage => new PropertyGetters(driver).
            GetVisibleWebElement(SuccessfulLoginPageMap.addedProductMessage);

        public IWebElement AddToCompareIcon => new PropertyGetters(driver).
            GetClickableWebElement(SuccessfulLoginPageMap.addToCompareIcon);

        public IWebElement MainPageProductContainer => new PropertyGetters(driver).
            GetClickableWebElement(SuccessfulLoginPageMap.mainPageProductContainer);

        public IWebElement WelcomeMessage => new  PropertyGetters(driver).
            GetVisibleWebElement(SuccessfulLoginPageMap.welcomeMessage);

        public IWebElement CompareProductsItemsLink => new PropertyGetters(driver).
            GetClickableWebElement(SuccessfulLoginPageMap.compareProductsLink);

    }
}
