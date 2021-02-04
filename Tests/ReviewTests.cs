using MagentoLv553SET.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace MagentoLv553SET.Tests
{
    [TestFixture]
    class ReviewTests:BaseTest
    {
        [Test]
        public void AddReviewTest()
        {
            var productPage = new ProductPageBL(webDriver);
            productPage               
                .EnterReview();

            var expectedResult = "You submitted your review for moderation.";
            var actualResult = new ProductPageBL(webDriver).GetSuccessfulAddReviewMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
        /*public void AddReviewWithoutLoginTest()
        {
            var productPage = new ProductPageBL(webDriver);
            productPage
                .EnterReview();

            var expectedResult = "You submitted your review for moderation.";
            var actualResult = new ProductPageBL(webDriver).GetSuccessfulAddReviewMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));*/
        //}
        [Test]
        public void EmptyRatingTest()
        {
            var productPage = new ProductPageBL(webDriver);
            productPage
                .EnterReviewWithoutRating();

            var expectedResult = "Please select one of each of the ratings above.";
            var actualResult = new ProductPageBL(webDriver).GetEmptyRatingErroMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [Test]
        public void EmptySummaryFiedTest()
        {
            var productPage = new ProductPageBL(webDriver);
            productPage
                .EnterReviewWithoutSummary();

            var expectedResult = "This is a required field.";
            var actualResult = new ProductPageBL(webDriver).GetEmptySummaryErroMessage();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }
    }
}
