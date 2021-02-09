using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Components.ShoppingCartComponents;

namespace MagentoLv553SET.Steps
{
    class HomePageBL
    {
        private readonly HomePage homePage;
        protected IWebDriver webDriver;

        public HomePageBL(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            homePage = new HomePage(webDriver);
        }

        public SearchComponentBL GetSearchComponentBL ()
        {
            return new SearchComponentBL (webDriver);
        }
        
        public HomePageBL SearchingAndAddingToCartProducts(List<string> productsList)
        {
            foreach(string productName in productsList)
            {
                SearchProduct(productName).AddingProductToTheShoppingCart(productName);
            }

            return new HomePageBL(webDriver);
        }

        public SearchPageBL SearchProduct(string productName)
        {
            homePage.ClickOnSearchInput();
            homePage.SendKeysToSearchInput(productName);
            homePage.SearchInput.Submit();

            return new SearchPageBL(webDriver);
        }

        public AuthorizationPageBL ClickOnMainSignInButton()
        {
            homePage.MainSignInButton.Click();
            return new AuthorizationPageBL(webDriver);
        }

        public ShoppingCartDropDownComponentBL OpenNotEmptyShoppingCartDropDown()
        {
            homePage.ClickOnNotEmptyShoppingCartButton();
            return new ShoppingCartDropDownComponentBL(webDriver);
        }

        public ShoppingCartDropDownComponent OpenEmptyShoppingCartDropDown()
        {
            homePage.ClickOnShoppingCartButton();
            return new ShoppingCartDropDownComponent(webDriver);
        }

        public HomePageBL CloseShoppingCartDropDown()
        {
            homePage.ShoppingCartDropDown.ClickOnCloseDropDownButton();
            return this;
        }
    }
}