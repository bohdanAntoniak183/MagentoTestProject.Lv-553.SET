using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumPageObject.Pages;
using SeleniumPageObject.Steps;

namespace SeleniumPageObject.Tests
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
