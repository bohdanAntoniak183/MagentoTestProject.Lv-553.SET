using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Steps;

namespace MagentoLv553SET.Tests
{
    [TestFixture]
    class AuthorizationTests : BaseTest
    {
        [Test]
        public void AuthorizationTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnMainSignInButton()
                .LogIntoAccount();

            var expectedResult = "Welcome";
            var actualResult = new SuccessfulLoginPageBL(webDriver).GetWelcomeMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
