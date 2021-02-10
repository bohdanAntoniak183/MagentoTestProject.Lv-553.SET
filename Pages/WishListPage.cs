using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Pages
{
    class WishListPage : HomePage
    {
        public WishListPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement WishListTitle => new PropertyGetters(driver).
            GetVisibleWebElement(WishListPageMap.wishListTitle);

        public IWebElement AddedTowishListMessage => new PropertyGetters(driver).
            GetVisibleWebElement(WishListPageMap.addedTowishListMessage);
    }
}
