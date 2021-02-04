using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Components;
using OpenQA.Selenium.Support.UI;

namespace MagentoLv553SET.Pages
{
    class ReviewTabPage : BasePage
    {


        public ReviewTabPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement NicknameField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ReviewTabMap.nicknameField));
                return driver.FindElement(ReviewTabMap.nicknameField);
            }
        }

        public IWebElement SummaryField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ReviewTabMap.summaryField));
                return driver.FindElement(ReviewTabMap.summaryField);
            }
        }
        public IWebElement ReviewField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ReviewTabMap.reviewField));
                return driver.FindElement(ReviewTabMap.reviewField);
            }
        }
        public IWebElement RatingReview
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ReviewTabMap.ratingReview));
                return driver.FindElement(ReviewTabMap.ratingReview);
            }
        }
        public IWebElement SubmitReviewButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementToBeClickable(ReviewTabMap.submitReviewButton));
                return driver.FindElement(ReviewTabMap.submitReviewButton);
            }
        }
        public IWebElement EmptyRatingErrorMessage
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ReviewTabMap.emptyRatingErrorMessage));
                return driver.FindElement(ReviewTabMap.emptyRatingErrorMessage);
            }
        }
        public IWebElement EmptySummaryErrorMessage
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ReviewTabMap.emptySummaryErrorMessage));
                return driver.FindElement(ReviewTabMap.emptySummaryErrorMessage);
            }
        }
        public IWebElement EmptyReviewErrorMessage
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(ReviewTabMap.emptyReviewErrorMessage));
                return driver.FindElement(ReviewTabMap.emptyReviewErrorMessage);
            }
        }
        public string EmptyRatingErrorMessageText()
        {
            return EmptyRatingErrorMessage.Text;
        }
        public string EmptySummaryErrorMessageText()
        {
            return EmptySummaryErrorMessage.Text;
        }
        public string EmptyReviewErrorMessageText()
        {
            return EmptyReviewErrorMessage.Text;
        }
    }
}
