using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Components;
using OpenQA.Selenium;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Pages
{
    class WishListSharingPage : AMenuPart
    {

        public WishListSharingPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement EmailsField => new PropertyGetters(driver).GetVisibleWebElement(WishListSharingPageMap.emailsField);

        public IWebElement MessageField => new PropertyGetters(driver).GetVisibleWebElement(WishListSharingPageMap.messageField);

        public IWebElement ShareWishListButton => new PropertyGetters(driver).GetVisibleWebElement(WishListSharingPageMap.shareWishListButton);

        public IWebElement MessageAboutIncorrectEmail => new PropertyGetters(driver).GetVisibleWebElement(WishListSharingPageMap.messageAboutIncorrectEmail);


        public void SendKeysToEmailsField(string data)
        {
            EmailsField.SendKeys(data);
        }


        public void SendKeysToMessageField(string data)
        {
            MessageField.SendKeys(data);
        }

        public void ClickOnShareWishListButton()
        {
            ShareWishListButton.Click();
        }

        public void ClickOnEmailsField()
        {
            EmailsField.Click();
        }

        public void ClickOnMessageField()
        {
            MessageField.Click();
        }

        public string GetMessageAboutIncorrectEmail()
        {
            return MessageAboutIncorrectEmail.Text;
        }






    }
}
