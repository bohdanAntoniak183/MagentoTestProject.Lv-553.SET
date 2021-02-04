using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Components;
using OpenQA.Selenium;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Pages
{
    class WishListSharingPage : AMenuPart
    {

        public WishListSharingPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement EmailsField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListSharingPageMap.emailsField));
                return driver.FindElement(WishListSharingPageMap.emailsField);
            }
        }

        public IWebElement MessageField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListSharingPageMap.messageField));
                return driver.FindElement(WishListSharingPageMap.messageField);
            }
        }


        public IWebElement ShareWishListButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListSharingPageMap.shareWishListButton));
                return driver.FindElement(WishListSharingPageMap.shareWishListButton);
            }
        }

        public IWebElement MessageAboutIncorrectEmail
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(WishListSharingPageMap.messageAboutIncorrectEmail));
                return driver.FindElement(WishListSharingPageMap.messageAboutIncorrectEmail);
            }
        }

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
