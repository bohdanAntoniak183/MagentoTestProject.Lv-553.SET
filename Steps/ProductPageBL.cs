using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Data;
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

        public ProductPageBL EnterReview()
        {
            ClickOnAddReviewButton();
            ClickOnRating();
            InputNicknameField();
            InputSummaryField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(webDriver);
        }
        public ProductPageBL DigitalsInAllFielsReview()
        {
            ClickOnAddReviewButton();
            ClickOnRating();
            InputNicknameField();
            InputSummaryField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(webDriver);
        }

        public ProductPageBL EnterReviewWithoutRating()
        {
            ClickOnAddReviewButton();
            InputNicknameField();
            InputSummaryField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(webDriver);
        }
        public ProductPageBL EnterReviewWithoutSummary()
        {
            ClickOnAddReviewButton();
            ClickOnRating();
            InputNicknameField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(webDriver);
        }
        public ProductPageBL EnterReviewWithoutLogin()
        {
            ClickOnAddReviewButton();
            ClickOnRating();
            InputNicknameField();
            InputSummaryField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(webDriver);
        }
        public void ClickOnAddReviewButton()
        {
            productPage.AddReview.Click();
        }
        public void ClickOnOpenReviewButton()
        {
            productPage.OpenReview.Click();
        }
         
        public void ClickOnRating()
        {
            String javascript = "arguments[0].click()";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)webDriver;
            jsExecutor.ExecuteScript(javascript, productPage.reviewTabPage.RatingReview);
        }
        public void InputNicknameField()
        {
            productPage.reviewTabPage.NicknameField.Clear();
            productPage.reviewTabPage.NicknameField.SendKeys(TestsData.nickname);

        }
        public void InputSummaryField()
        {
            productPage.reviewTabPage.SummaryField.Clear();
            productPage.reviewTabPage.SummaryField.SendKeys(TestsData.summaryText);
        }
        public void InputReviewField()
        {
            productPage.reviewTabPage.ReviewField.Clear();
            productPage.reviewTabPage.ReviewField.SendKeys(TestsData.reviewText);
        }
        public void ClickOnSubmitReviewButton()
        {
            productPage.reviewTabPage.SubmitReviewButton.Click();
        }

        public string GetSuccessfulAddReviewMessage()
        {
            string AddMessaege = productPage.SuccessfulAddReviewMessageText();
            return AddMessaege;
        }
        public string GetEmptyRatingErroMessage()
        {
            string AddMessaege = productPage.reviewTabPage.EmptyRatingErrorMessageText();
            return AddMessaege;
        }
        public string GetEmptySummaryErroMessage()
        {
            string AddMessaege = productPage.reviewTabPage.EmptySummaryErrorMessageText();
            return AddMessaege;
        }
        public string GetEmptyReviewErroMessage()
        {
            string AddMessaege = productPage.reviewTabPage.EmptyReviewErrorMessageText();
            return AddMessaege;
        }
    }
}
