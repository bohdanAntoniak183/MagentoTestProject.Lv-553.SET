using System;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using MagentoLv553SET.Steps;

namespace MagentoLv553SET.Containers
{
    class ProductContainer: BasePage
    {
        private IWebElement webElement;

        public IWebElement Name
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.productNameMap));
                return driver.FindElement(ProductContainerMap.productNameMap);
            }
        }

        public IWebElement Price
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.productPriceMap));
                return driver.FindElement(ProductContainerMap.productPriceMap);
            }
        }

        public IWebElement ShoppingCartButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.addToCartMap));
                return driver.FindElement(ProductContainerMap.addToCartMap);
            }
        }

        public IWebElement AddToWishListWButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.addToWishListMap));
                return driver.FindElement(ProductContainerMap.addToWishListMap);
            }
        }

        public IWebElement AddToCompareButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.addToCompareMap));
                return driver.FindElement(ProductContainerMap.addToCompareMap);
            }
        }

        public ProductContainer(IWebElement webElement, IWebDriver webDriver) : base(webDriver)
        {
            this.webElement = webElement;
        }

        public string GetName ()
        {
            return Name.Text;
        }

        public void ClickOnName()
        {
            Name.Click();
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

        public ProductPageBL OpenProductPage()
        {
            ClickOnName();
            return new ProductPageBL(driver);
        }
    }
}
