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
            IList<IWebElement> productList = new PropertyGetters(driver).GetWebElements(ShoppingCartDropDownMap.productNameMap);

            List<string> productNameList = new List<string>();

            foreach(IWebElement product in productList)
            {
                productNameList.Add(product.Text);
            }

            return productNameList;
        }

        public List<string> GetListOfProductsPrices()
        {
            IList<IWebElement> productList = new PropertyGetters(driver).GetWebElements(ShoppingCartDropDownMap.productPriceMap);

            List<string> productPriceList = new List<string>();

            foreach (IWebElement product in productList)
            {
                productPriceList.Add(product.Text);
            }

            return productPriceList;
        }

        public int GetNumberOfProducts()
        {
            IList<IWebElement> productList = new PropertyGetters(driver).GetWebElements(ShoppingCartDropDownMap.productNameMap);

            return productList.Count;
        }

        // TODO
        //public IWebElement GetTheRemoveButtonOfTheProduct(string productName)
        //{
            
        //}
    }
}
