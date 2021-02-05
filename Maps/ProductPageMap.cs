using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class ProductPageMap
    {
        public static readonly By addToCompareButton =  By.XPath("//*[@class='action tocompare']");
        public static readonly By addedProductMessage = By.XPath("//*[@data-bind='html: message.text']");
        public static readonly By mainPageDropDown = By.XPath("//button[@class='action switch']");
        public static readonly By myAccountButton = By.XPath("//a[text()='My Account']");
    }
}
