using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Data;
using OpenQA.Selenium;

namespace MagentoLv553SET.Steps
{
    class WishListSharingPageBL : HomePageBL
    {
        private readonly  WishListSharingPage wishListSharingPage;

        public WishListSharingPageBL(IWebDriver webDriver) : base(webDriver)
        {
            wishListSharingPage = new WishListSharingPage(webDriver);
        }

        public WishListSharingPageBL InputEmailToEmailsField()
        {
            wishListSharingPage.ClickOnEmailsField();
            wishListSharingPage.SendKeysToEmailsField(TestsData.logInEmail);
            return this;
        }

        public WishListSharingPageBL InputIncorrectEmailToEmailsField()
        {
            wishListSharingPage.ClickOnEmailsField();
            wishListSharingPage.SendKeysToEmailsField(TestsData.incorrectEmailForWishListSharingPage);
            return this;
        }

        public WishListSharingPageBL InputMassageToMessageField()
        {
            wishListSharingPage.ClickOnMessageField();
            wishListSharingPage.SendKeysToMessageField(TestsData.sharingMessage);
            return this;
        }

        public WishListPageBL ShareWishList()
        {
            wishListSharingPage.ClickOnShareWishListButton();
            return new WishListPageBL(webDriver);
        }

        public WishListSharingPageBL ShareWishListWithIncorrectEmail()
        {
            wishListSharingPage.ClickOnShareWishListButton();
            return this;
        }

        public string GetFailSharingMessage()
        {
            string seccessSharingMessage = wishListSharingPage.GetMessageAboutIncorrectEmail();
            return seccessSharingMessage;
        }



    }
}
