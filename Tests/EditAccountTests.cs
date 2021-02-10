using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Steps;
using NUnit.Allure.Core;

namespace MagentoLv553SET.Tests
{
    [TestFixture]
    [AllureNUnit]
    class EditAccountTests : BaseTest
    {
        [Test]
        public void ChangePasswordTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .ClickOnCreateAnAccountButton()
                .CreateAnAccount()
                .ClickOnChangePasswordLink();  

            var expectedEditAccountTitle = "Edit Account Information";
            var actualTitle = new EditAccountInformationPageBL(webDriver).GetEditAccountTitle();
            Assert.IsTrue(actualTitle.Contains(expectedEditAccountTitle));

            var changePassword = new EditAccountInformationPageBL(webDriver);

            changePassword
             .ChangePassword();
            var expectedSuccessMessage = "You saved the account information.";
            var actual = new SuccessfulRegistrationPageBL(webDriver).GetSuccessSavingInformationMessage();
            Assert.IsTrue(actual.Contains(expectedSuccessMessage));

        }

    }
}
