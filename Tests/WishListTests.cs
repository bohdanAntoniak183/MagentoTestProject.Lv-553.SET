using MagentoLv553SET.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Tests
{
    [TestFixture]
    class WishListTests : BaseTest
    {
        [Test]
        public void AddToWishListTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnFucionBackPackButton()
                .ClickOnAddToWishListButton();

            var expectedResult = "has been added to your Wish List.";
            var actualResult = new WishListPageBL(webDriver).GetSuccessAddedMessage();
            Console.WriteLine(actualResult);
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void RemoveFromWishListTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnFucionBackPackButton()
                .ClickOnAddToWishListButton()
                .ClickOnRemoveFromWishListButton();

            var expectedResult = "has been removed from your Wish List.";
            var actualResult = new WishListPageBL(webDriver).GetSuccessRemovedMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void AddToWishListFromSuccessfulLoginPageTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnAddToWishListButtonforFusionBackpackProduct();

            var expectedResult = "has been added to your Wish List.";
            var actualResult = new WishListPageBL(webDriver).GetSuccessAddedMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void UpdateWishListTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnFucionBackPackButton()
                .ClickOnAddToWishListButton()
                .InputCountForFusionBackPackProduct()
                .ClickOnUpdateWishListButton();

            var expectedResult = "has been updated in your Wish List.";
            var actualResult = new WishListPageBL(webDriver).GetSuccessUpdatedMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void AddToShoppingCartTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnFucionBackPackButton()
                .ClickOnAddToWishListButton()
                .ClickOnAddToCartButtonForFusionBackPack();

            var expectedResult = "to your shopping cart.";
            var actualResult = new WishListPageBL(webDriver).GetSuccessAddedToShoppingCartMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void AddAllProductsToShoppingCartTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnAddToWishListButtonforFusionBackpackProduct()
                .GoToHomePage()
                .ClickOnAddToWishListButtonforPushItMessangerBagProduct()
                .ClickOnAddAllProductsToCartButton();
                

            var expectedResult = "product(s) have been added to shopping cart:";
            var actualResult = new WishListPageBL(webDriver).GetSuccessAddedAllProductsToShoppingCartMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
