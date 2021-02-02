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
        { get { return driver.FindElement(By.CssSelector("div.panel.header li.greet.welcome span")); } }
        public IWebElement SignInButton
        { get { return driver.FindElement(By.CssSelector("div.panel.header li.authorization-link a")); } }
        public IWebElement CreateAccountButton
        { get { return driver.FindElement(By.XPath("//div[@class = 'panel header']//a[contains(@href, 'account/create')]")); } }
        public IWebElement Logo
        { get { return driver.FindElement(By.CssSelector("a.logo")); } }
        public IWebElement SearchInput
        { get { return driver.FindElement(By.CssSelector("input#search")); } }
        public IWebElement ShoppingCartButton
        { get { return driver.FindElement(By.PartialLinkText("checkout/cart")); } }

        public string GetWelcomeLabelText()
        {
            return WelcomeLabel.Text;
        }

        public AuthorizationPage ClickOnSignInButton()
        {
            SignInButton.Click();
            return new AuthorizationPage(driver);
        }

        public void ClickOnCreateAccountButton()
        {
            CreateAccountButton.Click();
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
