using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;
using OpenQA.Selenium;

namespace MagentoLv553SET.Steps
{
    class ProductPageBL : SuccessfulLoginPageBL
    {
        private readonly ProductPage productPage;
        public ProductPageBL(IWebDriver webDriver) : base(webDriver)
        {
            productPage = new ProductPage(webDriver);
        }
        public SuccessfulAddedProductPageBL ClickOnAddToCompareButton()
        {
            productPage.AddToCompareButton.Click();
            return new SuccessfulAddedProductPageBL(webDriver);
        }
    }
}
