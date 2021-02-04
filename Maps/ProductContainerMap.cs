using System;
using OpenQA.Selenium;

namespace MagentoLv553SET.Maps
{
    class ProductContainerMap
    {
        public static readonly By productNameMap = By.CssSelector(".product-item-link");
        public static readonly By productPriceMap = By.CssSelector(".price");
        public static readonly By addToCartMap = By.CssSelector("[title='Add to Cart']");
        public static readonly By addToWishListMap = By.CssSelector("[title='Add to Wish List']");
        public static readonly By addToCompareMap = By.CssSelector("[title='Add to Compare']");
        public static readonly By allProducts = By.CssSelector(".item.product.product-item");
    }
}
