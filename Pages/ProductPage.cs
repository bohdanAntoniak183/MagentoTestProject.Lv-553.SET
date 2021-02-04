using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Components;

namespace MagentoLv553SET.Pages
{
    class ProductPage : AMenuPart
    {
        public ProductPage(IWebDriver webDriver) : base(webDriver)
        {
            reviewTabPage = new ReviewTabPage(webDriver);
        }

        public ReviewTabPage reviewTabPage;
       

        public IWebElement AddToCartButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ProductPageMap.addToCartButton));
                return driver.FindElement(ProductPageMap.addToCartButton);
            }
        }

        public IWebElement AddToWishList
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ProductPageMap.addToWishList));
                return driver.FindElement(ProductPageMap.addToWishList);
            }
        }
        public IWebElement AddToCompare
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ProductPageMap.addToCompare));
                return driver.FindElement(ProductPageMap.addToCompare);
            }
        }
        public IWebElement CreateEmail
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ProductPageMap.createEmail));
                return driver.FindElement(ProductPageMap.createEmail);
            }
        }
        public IWebElement OpenReview
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductPageMap.openReview));
                return driver.FindElement(ProductPageMap.openReview);
            }
        }
        public IWebElement AddReview
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductPageMap.addReview));
                return driver.FindElement(ProductPageMap.addReview);
            }
        }
        public IWebElement ProductCountField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ProductPageMap.productCountField));
                return driver.FindElement(ProductPageMap.productCountField);
            }
        }
        public IWebElement SuccessfulAddReviewMessage
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ProductPageMap.successfulAddReviewMessage));
                return driver.FindElement(ProductPageMap.successfulAddReviewMessage);
            }
        }
        public string SuccessfulAddReviewMessageText()
        {
            return SuccessfulAddReviewMessage.Text;
        }

    }
}
