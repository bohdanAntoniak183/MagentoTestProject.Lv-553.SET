using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using MagentoLv553SET.Pages;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Components
{
    abstract class AMenuPart : BasePage
    {
        public AMenuPart(IWebDriver webDriver) : base(webDriver)
        {

        }
    }
}
