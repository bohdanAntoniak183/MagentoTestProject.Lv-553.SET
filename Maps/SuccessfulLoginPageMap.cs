using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class SuccessfulLoginPageMap
    {
        public static readonly By welcomeMessage = By.XPath("//span[contains(text(),'Welcome')]");
        public static readonly By accountDropDown = By.XPath("//button[@class='action switch']");
        public static readonly By myAccountButton = By.XPath("//a[text()='My Account']");
        public static readonly By mainPageProductContainer = By.XPath("//*[@alt='Fusion Backpack']");
    }
}
