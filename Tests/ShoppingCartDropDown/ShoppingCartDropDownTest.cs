using OpenQA.Selenium;
using NUnit.Framework;
using MagentoLv553SET.Steps;
using MagentoLv553SET.Data;
using System.Collections.Generic;

namespace MagentoLv553SET.Tests.ShoppingCartDropDown
{
    class ShoppingCartDropDownTest : BaseTest
    {
        [Test]
        public void EmptyShoppingCartDropDownTest()
        {
            HomePageBL homePage = new HomePageBL(webDriver);

            string actualMessage = homePage.OpenEmptyShoppingCartDropDown().NoItemsTitle.Text;

            Assert.AreEqual(TestsData.emptyShoppingCartDropDownMessage, actualMessage);
        }

        [Test]
        public void AddingProductsToShoppingCartTest()
        {
            HomePageBL homePageBL = new HomePageBL(webDriver);

            List<string> actualProductNameList =  homePageBL
                .SearchingAndAddingToCartProducts(TestsData.productsNames)
                .OpenNotEmptyShoppingCartDropDown()
                .ProductContainer.GetListOfProductsNames();

            foreach (string element in TestsData.productsNames)
            {
                Assert.Contains(element, actualProductNameList);
            }
        }
    }
}
