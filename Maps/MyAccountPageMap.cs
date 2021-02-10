using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class MyAccountPageMap
    {
        public static readonly By myAccountCompareButton = By.XPath("//*[@class='action compare primary']");
        public static readonly By removedCompareProductMessage = By.XPath("//*[@class='page messages']");
        public static readonly By clearCompareProductsList = By.XPath("//*[@id='compare-clear-all']");
        public static readonly By questionMessage = By.XPath("//*[@class='action-primary action-accept']");
        public static readonly By clearedListMessage = By.XPath("//*[@data-bind='html: message.text']");
        public static readonly By compareProductDeleteButton = By.XPath("//*[@class='action delete']");
    }
}
