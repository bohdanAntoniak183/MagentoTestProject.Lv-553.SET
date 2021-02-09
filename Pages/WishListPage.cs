using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using OpenQA.Selenium;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Pages
{
    class WishListPage : AMenuPart
    {
        public WishListPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement ProductAddedMessage => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.MessageAboutAddingFusionBackPackToWishList);

        public IWebElement FusionBackPackInWishList => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.fusionBackpackProductInWishList);

        public IWebElement RemoveItemFusionBackPack => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.removeItemButton);

        public IWebElement MessageAboutRemoveingFusionBackPack => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.messageAboutRemoveingFusionBackPackFromWishList);

        public IWebElement CountOfProductsFieldForFusionBackPack => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.countOfProductsFieldForFusionBackPack);

        public IWebElement UpdateWishListButton => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.updateWishListButton);

        public IWebElement MessageAboutUpdatingFusionBackPackInWishList => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.messageAboutUpdatingFusionBackPackInWishList);

        public IWebElement ShareWishListButton => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.shareWishListButton);

        public IWebElement MyWishListPageTitle => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.myWishListPageTitle);

        public IWebElement AddToCartButton => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.addToCartButton);

        public IWebElement MessageAboutAddingFusionBackPackInShoppingCart => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.messageAboutAddingFusionBackPackInShoppingCart);

        public IWebElement AddAllToCartButton => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.addAllToCartButton);

        public IWebElement MessageAboutAddingAllProductsInShoppingCart => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.messageAboutAddingAllProductsInShoppingCart);

        public IWebElement MessageAboutSharingWishList => new PropertyGetters(driver).GetVisibleWebElement(WishListPageMap.messageAboutSharingWishList);


        public string GetProductAddedMessage()
        {
            return ProductAddedMessage.Text;
        }

        public void ClickOnRemoveItemFusionBackPack()
        {
            RemoveItemFusionBackPack.Click();
        }

        public string GetMessageAboutRemoveingFusionBackPack()
        {
            return MessageAboutRemoveingFusionBackPack.Text;
        }

        public void ClickOnCountOfProductsFieldForFusionBackPack()
        {
            CountOfProductsFieldForFusionBackPack.Click();
        }

        public void ClearCountOfProductsFieldForFusionBackPack()
        {
            CountOfProductsFieldForFusionBackPack.Clear();
        }

        public void SendKeysToCountOfProductsFieldForFusionBackPack(string data)
        {
            CountOfProductsFieldForFusionBackPack.SendKeys(data);
        }

        public void ClickOnUpdateWishListButton()
        {
            UpdateWishListButton.Click();
        }

        public string GetMessageAboutUpdatingFusionBackPackInWishList()
        {
            return MessageAboutUpdatingFusionBackPackInWishList.Text;
        }

        public void ClickOnShareWishListButton()
        {
            ShareWishListButton.Click();
        }

        public void ClickOnMyWishListPageTitle()
        {
            MyWishListPageTitle.Click();
        }

        public void ClickOnAddToCartButton()
        {
            AddToCartButton.Click();
        }

        public string GetMessageAboutAddingFusionBackPackInShoppingCart()
        {
            return MessageAboutAddingFusionBackPackInShoppingCart.Text;
        }

        public void ClickOnAddAllToCartButton()
        {
            AddAllToCartButton.Click();
        }

        public string GetMessageAboutAddingAllProductsInShoppingCart()
        {
            return MessageAboutAddingAllProductsInShoppingCart.Text;
        }

        public string GetMessageAboutSharingWishList()
        {
            return MessageAboutSharingWishList.Text;
        }





    }
}
