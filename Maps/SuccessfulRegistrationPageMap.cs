using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    public sealed class SuccessfulRegistrationPageMap
    {
        public static readonly By myAccountTitle = By.XPath("//span[@class = 'base']");
        public static readonly By changePasswordLink = By.XPath("//a[@class='action change-password']");

        private SuccessfulRegistrationPageMap()
        {
        }
    }
}
