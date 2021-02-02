using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;

namespace MagentoLv553SET.Steps
{
    class SuccessfulAddedProductPageBL : SuccessfulLoginPageBL
    {
        private readonly SuccessfulAddedProductPage successfulAddToCompareMessage;

        public SuccessfulAddedProductPageBL(IWebDriver webDriver) : base(webDriver)
        {
            successfulAddToCompareMessage = new SuccessfulAddedProductPage(webDriver);
        }
        public string GetSuccessfulMessage()
        {
            string successfulMessage = successfulAddToCompareMessage.AddedProductMessage.Text;
            return successfulMessage;
        }
    }
}
