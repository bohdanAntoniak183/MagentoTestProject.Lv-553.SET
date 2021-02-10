using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class CompareProductsPageMap
    {
        public static readonly By wishListButton = By.XPath("//*[@class='action towishlist']");
        public static readonly By addToCartButton = By.XPath("//*[@class='action tocart primary']");
        public static readonly By compareProductsPageTitle = By.XPath("//*[@class='base']");
        public static readonly By compareProductDeleteButton = By.XPath("//*[@class='action delete']");
        public static readonly By questionMessage = By.XPath("//*[@class='action-primary action-accept']");
        public static readonly By emptyListMessage = By.XPath("//*[@class='message info empty']");
        public static readonly By successfulProductMessage = By.XPath("//*[@class='message-success success message']");
    }
}
