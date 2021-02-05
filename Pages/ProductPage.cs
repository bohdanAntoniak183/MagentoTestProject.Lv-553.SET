using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Components;
using MagentoLv553SET.Util;
using OpenQA.Selenium.Support.UI;

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
                return new PropertyGetters(driver).GetClickableWebElement(ProductPageMap.addToCartButton);
            }
        }

        public IList<IWebElement> SizeList
        {
            get
            {

                return new PropertyGetters(driver).GetWebElements(ProductPageMap.sizeMap);
            }
        }

        public IList<IWebElement> ColorList
        {
            get
            {
                return new PropertyGetters(driver).GetWebElements(ProductPageMap.colorMap);
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

        public IWebElement SuccessfulAddedProductMessage
        {
            get
            {
                return new PropertyGetters(driver).GetVisibleWebElement(ProductPageMap.successfulAddedProductLabel);
            }
        }

        public string SuccessfulAddReviewMessageText()
        {
            return SuccessfulAddReviewMessage.Text;
        }

        public void ClickOnAddToCartButton()
        {
            AddToCartButton.Click();
        }
    }
}
