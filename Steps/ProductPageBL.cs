﻿using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Data;
using MagentoLv553SET.Pages;
using OpenQA.Selenium;

namespace MagentoLv553SET.Steps
{
    class ProductPageBL : HomePage
    {
        private readonly ProductPage productPage;
        public ProductPageBL(IWebDriver webDriver) : base(webDriver)
        {
            productPage = new ProductPage(webDriver);
        }


        public ProductPageBL EnterReview()
        {
            
            ClickOnAddReviewButton();
            ClickOnRating();
            InputNicknameField();
            InputSummaryField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(driver);
        }
        public ProductPageBL DigitalsInAllFielsReview()
        {

            ClickOnAddReviewButton();
            ClickOnRating();
            InputNicknameField();
            InputSummaryField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(driver);
        }

        public ProductPageBL EnterReviewWithoutRating()
        {
            ClickOnAddReviewButton();
            InputNicknameField();
            InputSummaryField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(driver);
        }
        public ProductPageBL EnterReviewWithoutSummary()
        {
            ClickOnAddReviewButton();
            ClickOnRating();
            InputNicknameField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(driver);
        }
        public ProductPageBL EnterReviewWithoutLogin()
        {
            ClickOnAddReviewButton();
            ClickOnRating();
            InputNicknameField();
            InputSummaryField();
            InputReviewField();
            ClickOnSubmitReviewButton();

            return new ProductPageBL(driver);
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
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
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
