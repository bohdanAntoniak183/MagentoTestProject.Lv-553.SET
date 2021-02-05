using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Steps
{
    class WishListPageBL : HomePageBL
    {
        private readonly WishListPage wishListPage;
        public WishListPageBL(IWebDriver webDriver) : base(webDriver)
        {
            wishListPage = new WishListPage(webDriver);
        }

        public string GetWishListTitle()
        {
            string wishListTitle = wishListPage.WishListTitle.Text;
            return wishListTitle;
        }
        public string GetAddedProductToWishListMessage()
        {
            string addedToWishListMessage = wishListPage.AddedTowishListMessage.Text;
            return addedToWishListMessage;
        }
    }
}
