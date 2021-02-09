using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Components.ShoppingCartComponents;
using OpenQA.Selenium;

namespace MagentoLv553SET.Steps
{
    class ShoppingCartDropDownComponentBL : HomePageBL
    {
        private readonly ShoppingCartDropDownComponent shoppingCartDropDownComponent;
        public ShoppingCartDropDownComponentBL(IWebDriver webDriver) : base(webDriver)
        {
            shoppingCartDropDownComponent = new ShoppingCartDropDownComponent(webDriver);
        }

        public ShoppingCartPageBL OpenShoppingCartPage()
        {
            shoppingCartDropDownComponent.ClickOnViewCartLink();
            return new ShoppingCartPageBL(webDriver);
        }

        public List<string> GetProductsNames()
        {
            return shoppingCartDropDownComponent.ProductContainer.GetListOfProductsNames();
        }

        public int GetProductsNumber()
        {
            return shoppingCartDropDownComponent.ProductContainer.GetNumberOfProducts();
        }

        public double GetTotalPrice()
        {
            return shoppingCartDropDownComponent.GetTotalPriceNumber();
        }
    }
}
