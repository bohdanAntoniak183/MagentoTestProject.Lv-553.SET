using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Maps;

using MagentoLv553SET.Util
using MagentoLv553SET.Components.ShoppingCartComponents;
using MagentoLv553SET.Steps;


namespace MagentoLv553SET.Components
{
    public abstract class AMenuPart : BasePage
    {
        public AMenuPart(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement WelcomeLabel => PropertyGetters.
            GetClickableWebElement(MenuPartMap.welcomeLableMap, driver);

        public IWebElement Logo => PropertyGetters.GetClickableWebElement(MenuPartMap.logoMap,driver);

        public IWebElement SearchInput => PropertyGetters.GetClickableWebElement(MenuPartMap.searchInputMap,driver);
        
        public IWebElement ShoppingCartButton => PropertyGetters.GetClickableWebElement(MenuPartMap.shoppingCartButtonMap,driver);
       
            

        public IWebElement SearchButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(MenuPartMap.searchButtonMap));
                return driver.FindElement(MenuPartMap.searchButtonMap);
            }
        }
        
        
        public ShoppingCartDropDownComponent ShoppingCartDropDown
        {
            get
            {
                ClickOnShoppingCartButton();
                return new ShoppingCartDropDownComponent(driver);
            }
        }     

        public string GetWelcomeLabelText()
        {
            return WelcomeLabel.Text;
        }

        public void ClickOnLogo()
        {
            Logo.Click();
        }

        public void ClickOnShoppingCartButton()
        {
            ShoppingCartButton.Click();
        }


        public void ClearSearchInput()
        {
            SearchInput.Clear();
        }

        public void ClickOnSearchInput()
        {
            SearchInput.Click();
        }

        public void SendKeysToSearchInput(string data)
        {
            SearchInput.SendKeys(data);
        }

        public void ClickOnSearchButton()
        {
            SearchButton.Click();
        }
    }
}
