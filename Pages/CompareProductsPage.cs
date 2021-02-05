using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Pages
{
    class CompareProductsPage : AMenuPart
    {
        public CompareProductsPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement CompareProductDeleteButton => new PropertyGetters(driver).
            GetVisibleWebElement(CompareProductsPageMap.compareProductDeleteButton);

        public IWebElement SuccessfulProductMessage => new PropertyGetters(driver).
            GetVisibleWebElement(CompareProductsPageMap.successfulProductMessage);

        public IWebElement EmptyListMessage => new PropertyGetters(driver).
            GetVisibleWebElement(CompareProductsPageMap.emptyListMessage);

        public IWebElement QuestionMessage => new PropertyGetters(driver).
            GetVisibleWebElement(CompareProductsPageMap.questionMessage);

        public IWebElement CompareProductsPageTitle => new PropertyGetters(driver).
            GetVisibleWebElement(CompareProductsPageMap.compareProductsPageTitle);

        public IWebElement AddToCartButton => new PropertyGetters(driver).
            GetVisibleWebElement(CompareProductsPageMap.addToCartButton);

        public IWebElement WishListButton => new PropertyGetters(driver).
            GetVisibleWebElement(CompareProductsPageMap.wishListButton);

    }
}
 