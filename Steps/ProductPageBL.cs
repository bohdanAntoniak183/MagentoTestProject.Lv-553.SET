using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;
using OpenQA.Selenium;

namespace MagentoLv553SET.Steps
{
    class ProductPageBL : HomePageBL
    {
        private readonly ProductPage productPage;
        public ProductPageBL(IWebDriver webDriver) : base(webDriver)
        {
            productPage = new ProductPage(webDriver);
        }
        public ProductPageBL ClickOnAddToCompareButton()
        {
            productPage.AddToCompareButton.Click();
            return this;
        }

        public MyAccountPageBL GoToMyAccountPage()
        {
            ClickOnAccountDropDown();
            ClickOnMyAccountButton();

            return new MyAccountPageBL(webDriver);
        }

        public string GetSuccessfulAddedProductMessage()
        {
            string successfulMessage = productPage.AddedProductMessage.Text;
            return successfulMessage;
        }
        public void ClickOnAccountDropDown()
        {
            productPage.MainPageDropDown.Click();
        }
        public void ClickOnMyAccountButton()
        {
            productPage.MyAccountButton.Click();
        }
    }
}
