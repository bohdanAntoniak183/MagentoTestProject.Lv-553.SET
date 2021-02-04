using OpenQA.Selenium;
using System.Collections.Generic;
using MagentoLv553SET.Util;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Components.ShoppingCartComponents
{
    public class ShoppingCartDropDownProductContainer
    {
        private IWebDriver driver;

        public ShoppingCartDropDownProductContainer(IWebDriver driver)
        {
            this.driver = driver;
        }

        public List<string> GetListOfProductsNames()
        {
            IReadOnlyCollection<IWebElement> productList = PropertyGetters.GetVisibleWebElements(
                ShoppingCartDropDownMap.productNameMap, driver);

            List<string> productNameList = new List<string>();

            foreach(IWebElement product in productList)
            {
                productNameList.Add(product.Text);
            }

            return productNameList;
        }

        public List<string> GetListOfProductsPrices()
        {
            IReadOnlyCollection<IWebElement> productList = PropertyGetters.GetVisibleWebElements(
                ShoppingCartDropDownMap.productPriceMap, driver);

            List<string> productPriceList = new List<string>();

            foreach (IWebElement product in productList)
            {
                productPriceList.Add(product.Text);
            }

            return productPriceList;
        }

        public int GetNumberOfProducts()
        {
            IReadOnlyCollection<IWebElement> productList = PropertyGetters.GetVisibleWebElements(
                ShoppingCartDropDownMap.productNameMap, driver);

            return productList.Count;
        }

        // TODO
        //public IWebElement GetTheRemoveButtonOfTheProduct(string productName)
        //{
            
        //}
    }
}
