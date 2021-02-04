using System;
using MagentoLv553SET.Components;
using OpenQA.Selenium;

namespace MagentoLv553SET.Steps
{
    class SearchComponentBL: HomePageBL
    {

        private readonly SearchComponent searchComponent;
        public SearchComponentBL(IWebDriver webDriver) : base(webDriver)
        {
            searchComponent = new SearchComponent(webDriver);
        }

        public SearchPageBL SearchText(string searchText)
        {
            searchComponent.ClearSearchInput();
            searchComponent.ClickOnSearchInput();
            searchComponent.SendKeysToSearchInput(searchText);
            searchComponent.ClickOnSearchButton();

            return new SearchPageBL (webDriver);
        }
    }
}
