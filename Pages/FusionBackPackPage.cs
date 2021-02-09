using MagentoLv553SET.Maps;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using MagentoLv553SET.Components;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Pages
{
    class FusionBackPackPage : AOptionsForProductComponent
    {
        public FusionBackPackPage(IWebDriver webDriver) : base(webDriver)
        {
          
        }
        //public IWebElement MessageForSuchBigCountOfProducts => new PropertyGetters(driver).GetVisibleWebElement(FusionBackPackPageMap.messageForSuchBigCountOfProducts);

        public IWebElement MessageForSuchBigCountOfProducts
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.TextToBePresentInElementLocated(FusionBackPackPageMap.messageForSuchBigCountOfProducts, "purchase is 10000."));
                return driver.FindElement(FusionBackPackPageMap.messageForSuchBigCountOfProducts);
            }
        }

        public string GetMessageForSuchBigCountOfProducts()
        {
            return MessageForSuchBigCountOfProducts.Text;
        }

    }
}
