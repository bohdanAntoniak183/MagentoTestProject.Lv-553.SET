using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Steps
{
    class FusionBackPackPageBL : HomePageBL
    {
        private readonly FusionBackPackPage fusionBackPackPage;

        public FusionBackPackPageBL(IWebDriver webDriver) : base(webDriver)
        {
            fusionBackPackPage = new FusionBackPackPage(webDriver);
        }


        public WishListPageBL ClickOnAddToWishListButton()
        {
            fusionBackPackPage.ClickOnAddToWishListButton();
            return new WishListPageBL(webDriver);
        }

        public string GetMessageForSuchBigCount()
        {
            string messageForSuchBigCount = fusionBackPackPage.GetMessageForSuchBigCountOfProducts();
            return messageForSuchBigCount;
        }

       

    }
}
