using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Pages
{
    class ProductPage : AMenuPart
    {
        public ProductPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement MyAccountButton => new PropertyGetters(driver).
            GetClickableWebElement(ProductPageMap.myAccountButton);

        public IWebElement MainPageDropDown => new PropertyGetters(driver).
            GetVisibleWebElement(ProductPageMap.mainPageDropDown);

        public IWebElement AddedProductMessage => new PropertyGetters(driver).
            GetVisibleWebElement(ProductPageMap.addedProductMessage);

        public IWebElement AddToCompareButton => new PropertyGetters(driver).
            GetVisibleWebElement(ProductPageMap.addToCompareButton);

    }
}
