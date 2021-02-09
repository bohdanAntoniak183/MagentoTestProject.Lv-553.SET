using MagentoLv553SET.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Attributes;
using System.ComponentModel;


namespace MagentoLv553SET.Tests
{
    [TestFixture]
    [AllureNUnit]
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

        [Test]
        public void ShareWishListTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnAddToWishListButtonforFusionBackpackProduct()
                .GoToWishListSharingPage()
                .InputEmailToEmailsField()
                .InputMassageToMessageField()
                .ShareWishList();


            var expectedResult = "Your wish list has been shared.";
            var actualResult = new WishListPageBL(webDriver).GetSuccessSharingMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void ShareWishListWithIncorrectEmailTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnAddToWishListButtonforFusionBackpackProduct()
                .GoToWishListSharingPage()
                .InputIncorrectEmailToEmailsField()
                .InputMassageToMessageField()
                .ShareWishListWithIncorrectEmail();


            var expectedResult = "Please enter valid email addresses, separated by commas. For example, johndoe@domain.com, johnsmith@domain.com.";
            var actualResult = new WishListSharingPageBL(webDriver).GetFailSharingMessage();

            Assert.AreEqual(expectedResult,actualResult);
        }

        [Test]
        public void AddToCartWithSuchBigCountOfProductsTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnFucionBackPackButton()
                .ClickOnAddToWishListButton()
                .InputSuchBigCountForFusionBackPackProduct()
                .ClickOnAddToCartButtonForIncorrectCountFusionBackPack();

            var expectedResult = "The most you may purchase is 10000.";
            var actualResult = new FusionBackPackPageBL(webDriver).GetMessageForSuchBigCount();
            Console.WriteLine(actualResult);
            Assert.AreEqual(expectedResult,actualResult);
        }

        [Test]
        public void AddToCartWithZeroCountOfProductsTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnFucionBackPackButton()
                .ClickOnAddToWishListButton()
                .InputZeroCountForFusionBackPackProduct()
                .ClickOnAddToCartButtonForFusionBackPack();
            
            var expectedResult = "to your shopping cart.";
            var actualResult = new WishListPageBL(webDriver).GetSuccessAddedToShoppingCartMessage();
            Console.WriteLine(actualResult);
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
