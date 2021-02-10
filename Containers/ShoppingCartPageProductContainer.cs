using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Util;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Containers
{
    class ShoppingCartPageProductContainer
    {
        private IWebDriver driver;

        public ShoppingCartPageProductContainer(IWebDriver driver)
        {
            this.driver = driver;
        }

        public List<string> GetNames()
        {
            IList<IWebElement> productList = new PropertyGetters(driver)
                .GetWebElements(ShoppingCartPageMap.productNameMap);

            List<string> productNameList = new List<string>();

            foreach (IWebElement product in productList)
            {
                productNameList.Add(product.Text);
            }

            return productNameList;
        }
    }
}
