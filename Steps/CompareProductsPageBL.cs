using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Steps
{
    class CompareProductsPageBL : HomePageBL
    {
        private readonly CompareProductsPage compareProductsPage;

        public CompareProductsPageBL(IWebDriver webDriver) : base(webDriver)
        {
            compareProductsPage = new CompareProductsPage(webDriver);
        }

        public CompareProductsPageBL DeleteItemFromProductPage()
        {
            ClickCompareProductDeleteButton();
            AsseptQuestionMessage();

            return new CompareProductsPageBL(webDriver);
        }

        public CompareProductsPageBL AddProductToCart()
        {
            ClickOnAddToCartButton();
            return this;
        }

        public WishListPageBL AddProductToWishList()
        {
            ClickOnWishListButton();
            return new WishListPageBL(webDriver);
        }

        public void ClickOnWishListButton()
        {
            compareProductsPage.WishListButton.Click();
        }
        public void ClickOnAddToCartButton()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(compareProductsPage.AddToCartButton).Build().Perform();
            compareProductsPage.AddToCartButton.Click();
        }

        public void AsseptQuestionMessage()
        {
            compareProductsPage.QuestionMessage.Click();
        }

        public void ClickCompareProductDeleteButton()
        {
            compareProductsPage.CompareProductDeleteButton.Click();
        }
        public string GetDeletedProductMessage()
        {
            string deletedProductMessage = compareProductsPage.SuccessfulProductMessage.Text;
            return deletedProductMessage;
        }
        public string GetEmptyListMessage()
        {
            string emptyListMessage = compareProductsPage.EmptyListMessage.Text;
            return emptyListMessage;
        }

        public string GetCompareProductsPageTitle()
        {
            string compareProductsPageTitle = compareProductsPage.CompareProductsPageTitle.Text;
            return compareProductsPageTitle;
        }

        public string GetAddedProductToCartMessage()
        {
            string addedToCartMessage = compareProductsPage.SuccessfulProductMessage.Text;
            return addedToCartMessage;
        }
    }
}
