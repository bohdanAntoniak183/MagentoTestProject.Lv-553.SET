using System;
using System.Collections.Generic;
using MagentoLv553SET.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MagentoLv553SET.Steps
{
    class SearchPageBL : HomePageBL
    {
        private readonly SearchPage searchPage;

        public SearchPageBL (IWebDriver webDriver) : base(webDriver)
        {
            searchPage = new SearchPage (webDriver);
            
        }

        public void VerifyProductNames(string expectedResult)
        {
            foreach (string actualText in GetListOfProductNames())
            {
                Assert.IsTrue(actualText.Contains(expectedResult));
            }
        }

        private List<string> GetListOfProductNames()
        {
            List<string> productNames = new List<string>();

            foreach (var element in searchPage.getProductsContainers())
            {
                productNames.Add(element.GetName());
            }

            return productNames;
        }
    }
}
