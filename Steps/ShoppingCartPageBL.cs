using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Pages;
using System.Globalization;

namespace MagentoLv553SET.Steps
{
    class ShoppingCartPageBL : HomePageBL
    {
        private readonly ShoppingCartPage shoppingCartPage;
        public ShoppingCartPageBL(IWebDriver driver) : base(driver)
        {
            shoppingCartPage = new ShoppingCartPage(driver);
        }

        public List<string> GetProductsNames()
        {
            return shoppingCartPage.ProductContainer.GetNames();
        }

        public double GetTotalPrice()
        {
            string totalPriceTitle = shoppingCartPage.GetTotalPriceTitleText();
            string changedPriceTitle = "";

            foreach (char character in totalPriceTitle)
            {
                if (Char.IsDigit(character) || Char.IsPunctuation(character))
                {
                    changedPriceTitle += character;
                }
            }

            NumberFormatInfo format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ".";

            return Convert.ToDouble(changedPriceTitle, format);
        }

        public ShoppingCartPageBL RemoveProduct(string productName)
        {
            shoppingCartPage.ClickOnRemoveProductButton(productName);
            return this;
        }
    }
}
