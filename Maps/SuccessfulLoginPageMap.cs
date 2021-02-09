using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class SuccessfulLoginPageMap
    {
        public static readonly By compareProductsLink = By.XPath("//*[@class='action compare']");
        public static readonly By comparisonListLink = By.XPath("//*[text()='comparison list']");
        public static readonly By addedProductMessage = By.XPath("//*[@data-bind='html: message.text']");
        public static readonly By welcomeMessage = By.XPath("//span[contains(text(),'Welcome')]");
        public static readonly By mainPageProductContainer = By.XPath("//*[@alt='Fusion Backpack']");
        public static readonly By addToCompareIcon = 
            By.XPath("//a[contains(@href,'fusion-backpack')]/following-sibling::div/descendant::a[@class='action tocompare']");
    }
}
