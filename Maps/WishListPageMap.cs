using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class WishListPageMap
    {
        public static readonly By MessageAboutAddingFusionBackPackToWishList = By.XPath("//div[@class='messages']");

        public static readonly By fusionBackpackProductInWishList = By.XPath("//*[@alt='Fusion Backpack']");

        public static readonly By removeItemButton = By.XPath("//*[@class='btn-remove action delete']");

        public static readonly By messageAboutRemoveingFusionBackPackFromWishList = By.XPath("//*[contains(text(),'has been removed')]");

        public static readonly By countOfProductsFieldForFusionBackPack = By.XPath("//a[contains(@href,'fusion-backpack')]/following-sibling::div[@class='product-item-inner']/descendant::input[@class='input-text qty']");

        public static readonly By updateWishListButton = By.XPath("//button[@class='action update']");

        public static readonly By messageAboutUpdatingFusionBackPackInWishList = By.XPath("//*[contains(text(),'has been updated')]");

        public static readonly By shareWishListButton = By.XPath("//button[@class='action share']");

        public static readonly By myWishListPageTitle = By.XPath("//*[@class='page-title']");

        public static readonly By addToCartButton = By.XPath("//a[contains(@href,'fusion-backpack')]/following-sibling::div[@class='product-item-inner']/descendant::div[@class='field qty']/following-sibling::div//button");

        public static readonly By messageAboutAddingFusionBackPackInShoppingCart = By.XPath("//*[contains(text(),'to your shopping cart.')]");

        public static readonly By addAllToCartButton = By.XPath("//*[@data-role='all-tocart']");

        public static readonly By messageAboutAddingAllProductsInShoppingCart = By.XPath("//*[contains(text(),'product(s) have been added to shopping cart:')]");

    }
}
