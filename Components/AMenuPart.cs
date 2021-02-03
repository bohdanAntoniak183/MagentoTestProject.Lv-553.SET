using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Steps;

namespace MagentoLv553SET.Components
{
    public abstract class AMenuPart : BasePage
    {
        //protected IWebDriver driver;
        protected IWebDriver webDriver;

        public AMenuPart(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement WelcomeLabel
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(MenuPartMap.welcomeLableMap));
                return driver.FindElement(MenuPartMap.welcomeLableMap);
            }
        }
        public IWebElement Logo
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(MenuPartMap.logoMap));
                return driver.FindElement(MenuPartMap.logoMap);
            }
        }
        public IWebElement SearchInput
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(MenuPartMap.searchInputMap));
                return driver.FindElement(MenuPartMap.searchInputMap);
            }
        }

        public IWebElement SearchButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(MenuPartMap.searchButtonMap));
                return driver.FindElement(MenuPartMap.searchButtonMap);
            }
        }

        
        public IWebElement ShoppingCartButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(MenuPartMap.shoppingCartButtonMap));
                return driver.FindElement(MenuPartMap.shoppingCartButtonMap);
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
