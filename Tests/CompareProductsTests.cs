using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Steps;
using OpenQA.Selenium;
using NUnit.Allure.Core;
using MagentoLv553SET.Pages;

namespace MagentoLv553SET.Tests
{
    [TestFixture]
    [AllureNUnit]
    [Parallelizable]
    class CompareProductsTests : BaseTest
    {

        [Test]
        public void AddProductToCompareListTest()
        {

            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnProductContainer()
                .ClickOnAddToCompareButton();

            var expectedResult = "You added product";
            var actualResult = new ProductPageBL(webDriver).GetSuccessfulAddedProductMessage();
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void AddProductToCompareListIconTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .AddProductToCompareList();

            var expectedResult = "You added product";
            var actualResult = new SuccessfulLoginPageBL(webDriver).GetSuccessfulAddedProductMessage();
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void ClearAllCompareListTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnProductContainer()
                .ClickOnAddToCompareButton()
                .GoToMyAccountPage()
                .ClearCompareProductsList();

            var expectedResult = "You cleared the comparison list.";
            var actualResult = new MyAccountPageBL(webDriver).GetClearedListMessage();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RemoveComparedProductXTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnProductContainer()
                .ClickOnAddToCompareButton()
                .GoToMyAccountPage()
                .DeleteCompareProductX();

            var expectedResult = "You removed product";
            var actualResult = new MyAccountPageBL(webDriver).GetDeletedProductMessage();
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void RemoveComparedProductTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .AddProductToCompareList()
                .GoToCompareProductsItemsPage()
                .DeleteItemFromProductPage();

            var firstExpectedResult = "You have no items to compare.";
            var secondExpectedResult = "You removed product";

            var firstActualResult = new CompareProductsPageBL(webDriver).GetEmptyListMessage();
            var secondActualResult = new CompareProductsPageBL(webDriver).GetDeletedProductMessage();

            Assert.AreEqual(firstExpectedResult, firstActualResult);
            Assert.IsTrue(secondActualResult.Contains(secondExpectedResult));
        }

        [Test]
        public void OpenCompareProductsPageThroughLinkTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .AddProductToCompareList()
                .GoToCompareProductsPage();

            var expectedResult = "Compare Products";
            var actualResult = new CompareProductsPageBL(webDriver).GetCompareProductsPageTitle();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OpenCompareProductsPageTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .ClickOnProductContainer()
                .ClickOnAddToCompareButton()
                .GoToMyAccountPage()
                .ClickOnCompareButton();

            var expectedResult = "Compare Products";
            var actualResult = new CompareProductsPageBL(webDriver).GetCompareProductsPageTitle();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AddFromCompareListToWishListTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .AddProductToCompareList()
                .GoToCompareProductsItemsPage()
                .AddProductToWishList();

            var firstExpectedResult = "My Wish List";
            var secondExpectedResult = "added to your Wish List";

            var firstActualResult = new WishListPageBL(webDriver).GetWishListTitle();
            var secondActualResult = new WishListPageBL(webDriver).GetAddedProductToWishListMessage();

            Assert.AreEqual(firstExpectedResult, firstActualResult);
            Assert.IsTrue(secondActualResult.Contains(secondExpectedResult));
        }

        [Test]
        public void AddFromCompareListToShoppingCartTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount()
                .AddProductToCompareList()
                .GoToCompareProductsPage()
                .AddProductToCart();

            var expectedResult = "shopping cart";
            var actualResult = new CompareProductsPageBL(webDriver).GetAddedProductToCartMessage();
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
