using System;
using NUnit.Framework;
using SeleniumPageObject.Tests;
using SeleniumPageObject.Steps;

namespace MagentoLv553SET.Tests.Search
{
    [TestFixture]
    public class SearchInNameTest : BaseTest
    {

        [Test]
        public void AuthorizationTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton();


            Assert.IsTrue();
        }
    }
}
