using OpenQA.Selenium;

namespace MagentoLv553SET.Maps
{
    class MenuPartMap
    {
        public static readonly By welcomeLableMap = By.CssSelector("div.panel.header li.greet.welcome span");
        public static readonly By logoMap = By.CssSelector("a.logo");
        public static readonly By searchInputMap = By.CssSelector("input#search");
        public static readonly By shoppingCartButtonMap = By.PartialLinkText("checkout/cart");
    }
}
