using System;
using NUnit.Framework;
using MagentoLv553SET.Steps;
using MagentoLv553SET.Pages;

namespace MagentoLv553SET.Tests.Search
{
    [TestFixture]
    public class SearchInNameTest : BaseTest
    {

        [Test]
        public void SearchTest()
        {
            var homePage = new HomePageBL(webDriver);
            homePage
                .GetSearchComponentBL()
                .SearchText("Tank");
            new SearchPageBL(webDriver)
                .GetListOfProductNames();

        }
    }
}
