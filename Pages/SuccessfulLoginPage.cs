using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Components;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Pages
{
    class SuccessfulLoginPage : HomePage
    {
        public SuccessfulLoginPage(IWebDriver webDriver) : base(webDriver)
        {

        }
        
        public IWebElement WelcomeMessage => new PropertyGetters(driver).GetVisibleWebElement(SuccessfulLoginPageMap.welcomeMessage);
        
        

        public string GetWelcomeMessage()
        {
            return WelcomeMessage.Text;
        }


        //public IWebElement WelcomeMessage
        //{
        //    get
        //    {
        //        wait.Until(SeleniumExtras.WaitHelpers.
        //            ExpectedConditions.ElementIsVisible(SuccessfulLoginPageMap.welcomeMessage));
        //        return driver.FindElement(SuccessfulLoginPageMap.welcomeMessage);
        //    }
        //}

    }
}
