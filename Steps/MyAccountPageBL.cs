using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Steps
{
    class MyAccountPageBL : HomePageBL
    {
        private readonly MyAccountPage myAccountPage;
        public MyAccountPageBL(IWebDriver webDriver) : base(webDriver)
        {
            myAccountPage = new MyAccountPage(webDriver);
        }

        public MyAccountPageBL ClearCompareProductsList()
        {
            ClearProductsList();
            AsseptClearingQuestionMessage();

            return this;
        }
        public MyAccountPageBL DeleteCompareProductX()
        {
            ClickDeleteProductXButton();
            AsseptDeletingQuestionMessage();

            return this;
        }

        public CompareProductsPageBL GoToCompareProductsPage()
        {
            ClickOnCompareButton();
            return new CompareProductsPageBL(webDriver);
        }

        public void ClickOnCompareButton()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(myAccountPage.MyAccountCompareButton).Build().Perform();
            myAccountPage.MyAccountCompareButton.Click();
        }

        public string GetClearedListMessage()
        {
            string successfulMessage = myAccountPage.ClearedListMessage.Text;
            return successfulMessage;
        }

        public string GetDeletedProductMessage()
        {
            string successfulMessage = myAccountPage.RemovedCompareProductMessage.Text;
            return successfulMessage;
        }

        public void ClickDeleteProductXButton()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(myAccountPage.CompareProductDeleteButton).Build().Perform();
            myAccountPage.CompareProductDeleteButton.Click();
        }

        public void ClearProductsList()
        {
            Actions action = new Actions(webDriver);
            action.MoveToElement(myAccountPage.ClearCompareProductsList).Build().Perform();
            myAccountPage.ClearCompareProductsList.Click();
        }
        public void AsseptClearingQuestionMessage()
        {
            myAccountPage.QuestionMessage.Click();
        }

        public void AsseptDeletingQuestionMessage()
        {
            myAccountPage.QuestionMessage.Click();
        }
    }
}
