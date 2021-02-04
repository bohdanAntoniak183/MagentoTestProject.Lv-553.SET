using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class WishListSharingPageMap
    {
        public static readonly By emailsField = By.XPath("//textarea[@id='email_address']");

        public static readonly By messageField = By.XPath("//textarea[@id='message']");

        public static readonly By shareWishListButton = By.XPath("//button[@class='action submit primary']");

        public static readonly By messageAboutIncorrectEmail = By.XPath("//div[@id='email_address-error']");
    }
}
