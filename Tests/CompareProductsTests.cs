using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Steps;

namespace MagentoLv553SET.Tests
{
    [TestFixture]
    class CompareProductsTests : BaseTest
    {
        [Test]
        public void AddToCompareListTest()
        {
            AuthorizationTests authorizationTests = new AuthorizationTests();
            authorizationTests.AuthorizationTest();

            var homePage = new SuccessfulLoginPageBL(webDriver);
            homePage
                .ClickOnProductContainer()
                .ClickOnAddToCompareButton();

            var expectedResult = "You added product";
            var actualResult = new SuccessfulAddedProductPageBL(webDriver).GetSuccessfulMessage();
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
