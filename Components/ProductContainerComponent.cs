using System;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Pages;
using OpenQA.Selenium;

namespace MagentoLv553SET.Components
{
    public class ProductContainerComponent: BasePage
    {

        private IWebElement webElement;

        public ProductContainerComponent(IWebElement webElement, IWebDriver webDriver) : base(webDriver)
        {
            this.webElement = webElement;
        }

        public string GetName()
        {
            return Name.Text;
        }

        public string GetPrice()
        {
            return Price.Text;
        }

        public IWebElement GetShoppingCartButton()
        {
            return ShoppingCartButton;
        }

        public IWebElement GetAddToWishListWButton()
        {
            return AddToWishListWButton;
        }

        public IWebElement GetAddToCompareButton()
        {
            return AddToCompareButton;
        }

        private IWebElement Name
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.productNameMap));
                return driver.FindElement(ProductContainerMap.productNameMap);
            }
        }

        private IWebElement Price
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.productPriceMap));
                return driver.FindElement(ProductContainerMap.productPriceMap);
            }
        }

        private IWebElement ShoppingCartButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.addToCartMap));
                return driver.FindElement(ProductContainerMap.addToCartMap);
            }
        }

        private IWebElement AddToWishListWButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.addToWishListMap));
                return driver.FindElement(ProductContainerMap.addToWishListMap);
            }
        }

        private IWebElement AddToCompareButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.addToCompareMap));
                return driver.FindElement(ProductContainerMap.addToCompareMap);
            }
        }
    }
}
