using System;
using System.Collections.Generic;
using System.Linq;
using MagentoLv553SET.Containers;
using MagentoLv553SET.Maps;
using OpenQA.Selenium;

namespace MagentoLv553SET.Pages
{
    class SearchPage: BasePage
    {
        public SearchPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public IList<ProductContainer> getProductsContainers()
        {
            foreach (var webElement in ProductsContainers)
            {
                listOfProductContainers.Add(new ProductContainer(webElement, driver));
            }

            return listOfProductContainers;
        }


        private IList<IWebElement> ProductsContainers
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.allProducts));
                return driver.FindElements(ProductContainerMap.allProducts).ToList();
            }
        }

        private IList<ProductContainer> listOfProductContainers;


    }
}
