using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using OpenQA.Selenium;

namespace MagentoLv553SET.Pages
{
    class WishListPage : AMenuPart
    {
        public WishListPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement ProductAddedMessage
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListPageMap.MessageAboutAddingFusionBackPackToWishList));
                return driver.FindElement(WishListPageMap.MessageAboutAddingFusionBackPackToWishList);
            }
        }

        public IWebElement FusionBackPackInWishList
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListPageMap.fusionBackpackProductInWishList));
                return driver.FindElement(WishListPageMap.fusionBackpackProductInWishList);
            }
        }

        public IWebElement RemoveItemFusionBackPack
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListPageMap.removeItemButton));
                return driver.FindElement(WishListPageMap.removeItemButton);
            }
        }

        public IWebElement MessageAboutRemoveingFusionBackPack
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListPageMap.messageAboutRemoveingFusionBackPackFromWishList));
                return driver.FindElement(WishListPageMap.messageAboutRemoveingFusionBackPackFromWishList);
            }
        }

        public IWebElement CountOfProductsFieldForFusionBackPack
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListPageMap.countOfProductsFieldForFusionBackPack));
                return driver.FindElement(WishListPageMap.countOfProductsFieldForFusionBackPack);
            }
        }

        public IWebElement UpdateWishListButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListPageMap.updateWishListButton));
                return driver.FindElement(WishListPageMap.updateWishListButton);
            }
        }

        public IWebElement MessageAboutUpdatingFusionBackPackInWishList
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListPageMap.messageAboutUpdatingFusionBackPackInWishList));
                return driver.FindElement(WishListPageMap.messageAboutUpdatingFusionBackPackInWishList);
            }
        }

        public IWebElement ShareWishListButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(WishListPageMap.shareWishListButton));
                return driver.FindElement(WishListPageMap.shareWishListButton);
            }
        }

        public IWebElement MyWishListPageTitle
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(WishListPageMap.myWishListPageTitle));
                return driver.FindElement(WishListPageMap.myWishListPageTitle);
            }
        }

        public IWebElement AddToCartButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(WishListPageMap.addToCartButton));
                return driver.FindElement(WishListPageMap.addToCartButton);
            }
        }

        public IWebElement MessageAboutAddingFusionBackPackInShoppingCart
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(WishListPageMap.messageAboutAddingFusionBackPackInShoppingCart));
                return driver.FindElement(WishListPageMap.messageAboutAddingFusionBackPackInShoppingCart);
            }
        }

        public IWebElement AddAllToCartButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(WishListPageMap.addAllToCartButton));
                return driver.FindElement(WishListPageMap.addAllToCartButton);
            }
        }

        public IWebElement MessageAboutAddingAllProductsInShoppingCart
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(WishListPageMap.messageAboutAddingAllProductsInShoppingCart));
                return driver.FindElement(WishListPageMap.messageAboutAddingAllProductsInShoppingCart);
            }
        }

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




    }
}
