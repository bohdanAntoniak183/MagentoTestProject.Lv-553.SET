using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumPageObject.Pages;
using SeleniumPageObject.Maps;

namespace SeleniumPageObject.Components
{
    abstract class AMenuPart : BasePage
    {
        public AMenuPart(IWebDriver webDriver) : base(webDriver)
        {

        }
    }
}
