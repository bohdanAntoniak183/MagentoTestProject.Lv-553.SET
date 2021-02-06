using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Steps;

namespace MagentoLv553SET.Tests
{
    [TestFixture]
    class RegistrationTests : BaseTest
    {
        [Test]
        public void RegistrationTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnCreateAnAccountButton()
                .CreateAnAccount();
            
            var  expectedResult = "My Account";
            var actualResult = new SuccessfulRegistrationPageBL(webDriver).GetMyAccountTitle();
            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
        [Test]
        public void TryToRegistrationWithEmptyFieldsTest() 
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnCreateAnAccountButton()
                .TryToCreateAnAccountWithEmptyFields(); 

            var expectedResult = "This is a required field";
            var actualResult = new RegistrationPageBL(webDriver).GetErrorMessage();
            Assert.IsTrue(actualResult.Contains(expectedResult));

        }
        [Test]
        public void TryToRegistrationWithWrongFormateDataTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnCreateAnAccountButton()
                .TryToCreateAnAccountWithWrongFormatData();

            var expectedResult = "Minimum of different classes of characters in password is 3." +
                " Classes of characters: Lower Case, Upper Case, Digits, Special Characters.";

            var actualResult = new RegistrationPageBL(webDriver).GetErrorMessageWrongPasswordFormat();
            Assert.IsTrue(actualResult.Contains(expectedResult));

        }
    }
}
