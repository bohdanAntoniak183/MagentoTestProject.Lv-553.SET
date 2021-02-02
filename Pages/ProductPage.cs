using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Pages
{
    class ProductPage : AMenuPart
    {
        public ProductPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement AddToCompareButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductPageMap.addToCompareButton));
                return driver.FindElement(ProductPageMap.addToCompareButton);
            }
        }
    }
}
