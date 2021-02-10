using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class WishListPageMap
    {
        public static readonly By wishListTitle = By.XPath("//*[@class='base']");
        public static readonly By addedTowishListMessage = By.XPath("//*[@class='message-success success message']");
    }
}
