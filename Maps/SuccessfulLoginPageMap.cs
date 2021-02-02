using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumPageObject.Maps
{
    class SuccessfulLoginPageMap
    {
        public static readonly By welcomeMessage = By.XPath("//span[contains(text(),'Welcome')]");
    }
}
