using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MagentoLv553SET.Steps;
using MagentoLv553SET.Data;

namespace MagentoLv553SET.Tests.ShoppingCartDropDown
{
    class ShoppingCartPageTest : BaseTest
    {
        [Test]
        public void AddingProductsToShoppingCartPageTest()
        {
            HomePageBL homePageBL = new HomePageBL(webDriver);

            List<string> actualProductNameList = homePageBL
                .SearchingAndAddingToCartProducts(TestsData.productsNames)
                .OpenNotEmptyShoppingCartDropDown()
                .OpenShoppingCartPage()
                .GetProductsNames();

            foreach (string element in TestsData.productsNames)
            {
                Assert.Contains(element, actualProductNameList);
            }
        }

        [Test]
        public void TotalPriceTest()
        {
            HomePageBL homePageBL = new HomePageBL(webDriver);

            double actualTotalPrice = homePageBL
                .SearchingAndAddingToCartProducts(TestsData.productsNames)
                .OpenNotEmptyShoppingCartDropDown()
                .OpenShoppingCartPage()
                .GetTotalPrice();

            Assert.AreEqual(TestsData.totalPriceOfProducts, actualTotalPrice);
        }

        [Test]
        public void RemoveProductTest()
        {
            HomePageBL homePageBL = new HomePageBL(webDriver);

            List<string> actualProductList = homePageBL
                .SearchingAndAddingToCartProducts(TestsData.productsNames)
                .OpenNotEmptyShoppingCartDropDown()
                .OpenShoppingCartPage()
                .RemoveProduct(TestsData.removedProductName)
                .GetProductsNames();

            List<string> expectedProductList = TestsData.productsNames;
            expectedProductList.Remove(TestsData.removedProductName);

            foreach (string element in expectedProductList)
            {
                Assert.Contains(element, actualProductList);
            }
        }
    }
}
