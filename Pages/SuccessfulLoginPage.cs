using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Components;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Pages
{
    class SuccessfulLoginPage : BasePage
    {
        public SuccessfulLoginPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        public IWebElement WelcomeMessage => new PropertyGetters(driver).GetVisibleWebElement(SuccessfulLoginPageMap.welcomeMessage);

    }
}
