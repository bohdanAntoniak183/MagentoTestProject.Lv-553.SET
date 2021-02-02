using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class ProductPageMap
    {
        public static readonly By addToCompareButton =
            By.XPath(
                "//*[@class='action mailto friend']/preceding-sibling::div/a[@class='action tocompare']"
                );
    }
}
