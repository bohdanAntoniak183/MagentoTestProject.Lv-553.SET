using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class ProductPageMap
    {
        public static readonly By addToCartButton = By.XPath("//*[@id='product-addtocart-button']");
        public static readonly By addToWishList = By.XPath("//*[@class='product-social-links']//descendant::a[1]");
        public static readonly By addToCompare = By.XPath("//*[@class='product-social-links']//descendant::a[2]");
        public static readonly By createEmail = By.XPath("//*[@class='product-social-links']//descendant::a[3]");
        public static readonly By openReview = By.XPath("//*[@class='action view']");
        public static readonly By addReview = By.XPath("//*[@class='action add']");
        public static readonly By productCountField = By.XPath("//*[@id='qty']");
        public static readonly By successfulAddReviewMessage = By.XPath("//*[@class='message-success success message']");
        public static readonly By sizeMap = By.XPath("//div[contains(@id, 'option-label-size')]");
        public static readonly By colorMap = By.XPath("//div[contains(@id, 'option-label-color')]");
        public static readonly By successfulAddedProductLabel = By.CssSelector("div.message-success.success.message");
    }
}
