﻿using OpenQA.Selenium;

namespace MagentoLv553SET.Maps
{
    class MenuPartMap
    {
        public static readonly By welcomeLableMap = By.CssSelector("div.panel.header li.greet.welcome span");
        public static readonly By logoMap = By.CssSelector("a.logo");
        public static readonly By searchInputMap = By.CssSelector("input#search");
        public static readonly By shoppingCartButtonMap = By.XPath("//a[@class = 'action showcart']");
        public static readonly By searchButtonMap = By.CssSelector(".action.search");
        public static readonly By shoppingCartProductsCounterMap = By.CssSelector("div.minicart-wrapper span.counter.qty");
    }
}
