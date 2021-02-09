using System;
using System.Collections.Generic;
using MagentoLv553SET.Pages;
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

        public List <string> GetListOfProductNames ()
        {

            List<string> productNames = new List<string>();

            foreach (var element in searchPage.getProductsContainers())
            {
                productNames.Add(element.GetName());
                Console.WriteLine(element.GetName());
            }

            return productNames;
        }
        //public List<string> GetListOfProductNames()
        //{

        //    List<string> productNames = new List<string>();

        //    foreach (var element in searchPage.getProductsContainers())
        //    {
        //        productNames.Add(element.GetName());
        //        Console.WriteLine(element.GetName());
        //    }

        //    return productNames;
        //}


    }
}
