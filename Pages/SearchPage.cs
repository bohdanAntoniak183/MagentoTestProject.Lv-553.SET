using System;
using System.Collections.Generic;
using System.Linq;
using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using OpenQA.Selenium;

namespace MagentoLv553SET.Pages
{
    class SearchPage: BasePage
    {

        private List<ProductContainerComponent> listOfProductContainers;

        public SearchPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public List<ProductContainerComponent> getProductsContainers()
        {
            listOfProductContainers = new List<ProductContainerComponent>();
            foreach (var webElement in ProductsContainers)
            {
                listOfProductContainers.Add(new ProductContainerComponent (webElement, driver));
            }

            return listOfProductContainers;
        }

        private List<IWebElement> ProductsContainers
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductContainerMap.allProducts));
                return driver.FindElements(ProductContainerMap.allProducts).ToList();
            }
        }
    }
}
