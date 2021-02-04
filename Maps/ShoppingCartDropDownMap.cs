using OpenQA.Selenium;

namespace MagentoLv553SET.Maps
{
    class ShoppingCartDropDownMap
    {
        public static readonly By closeDropDownButtonMap = By.CssSelector("button#btn-minicart-close");
        public static readonly By noItemsTitleMap = By.CssSelector("strong.subtitle.empty");
        public static readonly By itemsCountTitleMap = By.CssSelector("strong.subtitle.empty");
        public static readonly By totalPriceTitleMap = By.CssSelector("div.amount.price-container span.price");
        public static readonly By checkoutButtonMap = By.CssSelector("button#top-cart-btn-checkout");
        public static readonly By viewCartLinkMap = By.CssSelector("a.action.viewcart");
        public static readonly By productNameMap = By.CssSelector("li.item.product.product-item strong.product-item-name a");
        public static readonly By productPriceMap = By.CssSelector("ol#mini-cart span.price");
    }
}
