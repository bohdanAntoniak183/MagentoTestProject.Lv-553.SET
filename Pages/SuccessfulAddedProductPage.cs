using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using OpenQA.Selenium;

namespace MagentoLv553SET.Pages
{
    class SuccessfulAddedProductPage : AMenuPart
    {
        public SuccessfulAddedProductPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement AddedProductMessage
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(SuccessfulAddedProductPageMap.addedProductMessage));
                return driver.FindElement(SuccessfulAddedProductPageMap.addedProductMessage);
            }
        }
    }
}
