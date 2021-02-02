using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Components
{
    abstract class AMenuPart : BasePage
    {
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

        public void ClickOnShoppingCartButton()
        {
            ShoppingCartButton.Click();
        }
    }
}
