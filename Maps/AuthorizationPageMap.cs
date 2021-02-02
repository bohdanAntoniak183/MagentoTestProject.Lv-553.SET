using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace SeleniumPageObject.Maps
{
    class AuthorizationPageMap
    {
        public static readonly By emailField = By.XPath("//input[@id='email']");
        public static readonly By passwordField = By.XPath("//input[@id='pass']");
        public static readonly By signInButton = By.XPath("//*[@name='send']");
    }
}
