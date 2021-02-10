using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Pages;
using OpenQA.Selenium.Interactions;

namespace MagentoLv553SET.Steps
{
    class SuccessfulLoginPageBL : HomePageBL
    {
        private readonly SuccessfulLoginPage successfulLoginPage;
       

        public SuccessfulLoginPageBL(IWebDriver webDriver) : base(webDriver)
        {
            successfulLoginPage = new SuccessfulLoginPage(webDriver);
           
        }

        public ProductPageBL ClickOnProductContainer()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(successfulLoginPage.MainPageProductContainer).Build().Perform();
            successfulLoginPage.MainPageProductContainer.Click();
            return new ProductPageBL(webDriver);
        }

        public SuccessfulLoginPageBL AddProductToCompareList()
        {
            ClickOnAddToCompareIcon();
            return this;
        }

        public CompareProductsPageBL GoToCompareProductsPage()
        {
            ClickOnCompareProductsPageLink();
            return new CompareProductsPageBL(webDriver);
        }
        public CompareProductsPageBL GoToCompareProductsItemsPage()
        {
            ClickOnCompareProductsItemsPageLink();
            return new CompareProductsPageBL(webDriver);
        }

        public string GetWelcomeMessage()
        {
            string welcomeMessage = successfulLoginPage.WelcomeMessage.Text;
            return welcomeMessage;
        }

        public void ClickOnCompareProductsItemsPageLink()
        {
            successfulLoginPage.CompareProductsItemsLink.Click();
        }

        public void ClickOnCompareProductsPageLink()
        {
            successfulLoginPage.ComparisonListLink.Click();
        }

        public void ClickOnAddToCompareIcon()
        {
            successfulLoginPage.AddToCompareIcon.Click();
        }

        public string GetSuccessfulAddedProductMessage()
        {
            string successfulAddedProductMessage = successfulLoginPage.AddedProductMessage.Text;
            return successfulAddedProductMessage;
        }
    }
}
