using OpenQA.Selenium;
using MagentoLv553SET.Util;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Components.ShoppingCartComponents
{
    class ShoppingCartDropDownComponent
    {
        private IWebDriver driver;
        public ShoppingCartDropDownProductContainer ProductContainer
        { 
            get
            {
                return new ShoppingCartDropDownProductContainer(driver);
            }
        }

        public IWebElement CloseDropDownButton
        {
            get
            {
                return PropertyGetters.GetClickableWebElement(ShoppingCartDropDownMap.closeDropDownButtonMap,
                    driver);
            }
        }

        public IWebElement NoItemsTitle
        {
            get
            {
                return PropertyGetters.GetVisibleWebElement(ShoppingCartDropDownMap.noItemsTitleMap,
                    driver);
            }
        }

        public IWebElement ItemsCountTitle
        {
            get
            {
                return PropertyGetters.GetVisibleWebElement(ShoppingCartDropDownMap.itemsCountTitleMap,
                    driver);
            }
        }
        public IWebElement TotalPriceTitle
        {
            get
            {
                return PropertyGetters.GetVisibleWebElement(ShoppingCartDropDownMap.totalPriceTitleMap,
                    driver);
            }
        }
        public IWebElement CheckoutButton
        {
            get
            {
                return PropertyGetters.GetClickableWebElement(ShoppingCartDropDownMap.checkoutButtonMap,
                    driver);
            }
        }
        public IWebElement ViewCartLink
        {
            get
            {
                return PropertyGetters.GetClickableWebElement(ShoppingCartDropDownMap.viewCartLinkMap,
                    driver);
            }
        }
        

        public ShoppingCartDropDownComponent(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnCloseDropDownButton()
        {
            CloseDropDownButton.Click();
        }

        public string GetToItemsTitleText()
        {
            return NoItemsTitle.Text;
        }

        public string GetNoItemsTitleText()
        {
            return ItemsCountTitle.Text;
        }

        public string GetTotalPriceTitleText()
        {
            return TotalPriceTitle.Text;
        }

        public void ClickOnCheckOutButton()
        {
            CheckoutButton.Click();
        }

        public void ClickOnViewCartLink()
        {
            ViewCartLink.Click();
        }
    }
}
