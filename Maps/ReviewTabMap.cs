using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class ReviewTabMap
    {     
        public static readonly By nicknameField = By.XPath("//*[@id='nickname_field']");
        public static readonly By summaryField = By.XPath("//*[@id='summary_field']");
        public static readonly By reviewField = By.XPath("//*[@id='review_field']");
        public static readonly By submitReviewButton = By.XPath("//*[@class='action submit primary']");
        public static readonly By ratingReview = By.XPath("//*[@id='Rating_4_label']");
        public static readonly By emptyRatingErrorMessage = By.XPath("//*[@id='ratings[4]-error']");
        public static readonly By emptySummaryErrorMessage = By.XPath("//*[@id='summary_field-error']");
        public static readonly By emptyReviewErrorMessage = By.XPath("//*[@id='review_field-error']");
        
        
    }
}
