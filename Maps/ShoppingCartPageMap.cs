using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace MagentoLv553SET.Maps
{
    class ShoppingCartPageMap
    {
        public static readonly By totalPriceTitleMap = By.CssSelector("tr.grand.totals span.price");
        public static readonly By productNameMap = By.CssSelector("table#shopping-cart-table strong.product-item-name a");

        public static By GetRemoveButtonByName(string name)
        {
            return By.XPath($"//table[@id = 'shopping-cart-table']//a[text() = '{name}']" +
                $"/ancestor::tr[@class = 'item-info']" +
                $"/following-sibling::tr[@class = 'item-actions']//a[@title = 'Remove item']");
        }
    }
}
