using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Steps
{
    class WishListPageBL : HomePageBL
    {
        private readonly  WishListPage wishListPage;

        public WishListPageBL(IWebDriver webDriver) : base(webDriver)
        {
            wishListPage = new WishListPage(webDriver);
        }

        public string GetSuccessAddedMessage()
        {
            string productAddedMessage = wishListPage.GetProductAddedMessage();
            return productAddedMessage;
        }

        public string GetSuccessRemovedMessage()
        {
            string productRemovedMessage = wishListPage.GetMessageAboutRemoveingFusionBackPack();
            return productRemovedMessage;
        }

        public WishListPageBL ClickOnRemoveFromWishListButton()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(wishListPage.FusionBackPackInWishList).Build().Perform();
            wishListPage.ClickOnRemoveItemFusionBackPack();
            return new WishListPageBL(webDriver);
        }

        public WishListPageBL ClickOnUpdateWishListButton()
        {
            wishListPage.ClickOnMyWishListPageTitle();
            wishListPage.ClickOnUpdateWishListButton();
            return new WishListPageBL(webDriver);
        }


        public WishListPageBL InputCountForFusionBackPackProduct()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(wishListPage.FusionBackPackInWishList).Build().Perform();
            wishListPage.ClickOnCountOfProductsFieldForFusionBackPack();
            wishListPage.ClearCountOfProductsFieldForFusionBackPack();
            wishListPage.SendKeysToCountOfProductsFieldForFusionBackPack((new Random().Next(1,10)).ToString());
            return this;
        }

        public WishListPageBL InputSuchBigCountForFusionBackPackProduct()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(wishListPage.FusionBackPackInWishList).Build().Perform();
            wishListPage.ClickOnCountOfProductsFieldForFusionBackPack();
            wishListPage.ClearCountOfProductsFieldForFusionBackPack();
            wishListPage.SendKeysToCountOfProductsFieldForFusionBackPack((new Random().Next(10001, 10010)).ToString());
            return this;
        }

        public WishListPageBL InputZeroCountForFusionBackPackProduct()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(wishListPage.FusionBackPackInWishList).Build().Perform();
            wishListPage.ClickOnCountOfProductsFieldForFusionBackPack();
            wishListPage.ClearCountOfProductsFieldForFusionBackPack();
            wishListPage.SendKeysToCountOfProductsFieldForFusionBackPack("0");
            return this;
        }

        public string GetSuccessUpdatedMessage()
        {
            string productUpdatedMessage = wishListPage.GetMessageAboutUpdatingFusionBackPackInWishList();
            return productUpdatedMessage;
        }

        public WishListPageBL ClickOnAddToCartButtonForFusionBackPack()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(wishListPage.FusionBackPackInWishList).Build().Perform();
            wishListPage.ClickOnAddToCartButton();
            return new WishListPageBL(webDriver);
        }

        public FusionBackPackPageBL ClickOnAddToCartButtonForIncorrectCountFusionBackPack()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(wishListPage.FusionBackPackInWishList).Build().Perform();
            wishListPage.ClickOnAddToCartButton();
            return new FusionBackPackPageBL(webDriver);
        }

        public string GetSuccessAddedToShoppingCartMessage()
        {
            string productAddedToShoppingCartMessage = wishListPage.GetMessageAboutAddingFusionBackPackInShoppingCart();
            return productAddedToShoppingCartMessage;
        }

        public SuccessfulLoginPageBL GoToHomePage()
        {
            wishListPage.ClickOnLogo();
            return new SuccessfulLoginPageBL(webDriver);
        }

        public WishListPageBL ClickOnAddAllProductsToCartButton()
        {

            wishListPage.ClickOnAddAllToCartButton();
            return new WishListPageBL(webDriver);
        }

        public string GetSuccessAddedAllProductsToShoppingCartMessage()
        {
            string allProductsAddedToShoppingCartMessage = wishListPage.GetMessageAboutAddingAllProductsInShoppingCart();
            return allProductsAddedToShoppingCartMessage;
        }

        public WishListSharingPageBL GoToWishListSharingPage()
        {
            wishListPage.ClickOnShareWishListButton();
            return new WishListSharingPageBL(webDriver);
        }

        public string GetSuccessSharingMessage()
        {
            string seccessSharingMessage = wishListPage.GetMessageAboutSharingWishList();
            return seccessSharingMessage;
        }



    }
}
