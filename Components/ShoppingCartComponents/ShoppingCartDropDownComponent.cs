using OpenQA.Selenium;
using MagentoLv553SET.Util;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Components.ShoppingCartComponents
{
    public class ShoppingCartDropDownComponent
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
                return new PropertyGetters(driver).GetClickableWebElement(ShoppingCartDropDownMap.closeDropDownButtonMap);
            }
        }

        public IWebElement NoItemsTitle
        {
            get
            {
                return new PropertyGetters(driver).GetVisibleWebElement(ShoppingCartDropDownMap.noItemsTitleMap);
            }
        }

        public IWebElement ItemsCountTitle
        {
            get
            {
                return new PropertyGetters(driver).GetVisibleWebElement(ShoppingCartDropDownMap.itemsCountTitleMap);
            }
        }
        public IWebElement TotalPriceTitle
        {
            get
            {
                return new PropertyGetters(driver).GetVisibleWebElement(ShoppingCartDropDownMap.totalPriceTitleMap);
            }
        }
        public IWebElement CheckoutButton
        {
            get
            {
                return new PropertyGetters(driver).GetClickableWebElement(ShoppingCartDropDownMap.checkoutButtonMap);
            }
        }
        public IWebElement ViewCartLink
        {
            get
            {
                return new PropertyGetters(driver).GetClickableWebElement(ShoppingCartDropDownMap.viewCartLinkMap);
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
