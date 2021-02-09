using System;
using System.Collections.Generic;
using System.Linq;
using MagentoLv553SET.Containers;
using MagentoLv553SET.Maps;
using OpenQA.Selenium;
using MagentoLv553SET.Components;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Pages
{
    class SearchPage : AMenuPart
    {
        private List<ProductContainer> listOfProductContainers = new List<ProductContainer>();

        private IList<IWebElement> ProductsContainers
        {
            get
            {
                return new PropertyGetters(driver).GetWebElements(ProductContainerMap.allProducts);
            }
        }

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
    }
}
