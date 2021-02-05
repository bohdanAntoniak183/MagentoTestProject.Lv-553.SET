using System;
using MagentoLv553SET.Steps;
using NUnit.Framework;

namespace MagentoLv553SET.Tests
{

    [TestFixture]
    public class SearchTests : BaseTest
    {

        [Test]
        public void SearchInNameTest()
        {
            string textToSearch = "Tank";

            var homePage = new HomePageBL(webDriver);
            homePage
                .GetSearchComponentBL()
                .SearchText(textToSearch);
            new SearchPageBL(webDriver)
                .VerifyProductNames(textToSearch);
        }
    }
}
