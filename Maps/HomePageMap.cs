using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumPageObject.Maps
{
    class HomePageMap
    {
        public static readonly By mainSignInButton = By.XPath("//a[contains(@href,'/account/login')]");
    }
}
