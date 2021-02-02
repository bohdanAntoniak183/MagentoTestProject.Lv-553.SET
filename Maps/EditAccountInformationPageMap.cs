using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumPageObject.Pages
{
    class EditAccountInformationPageMap
{
        public static readonly By editAccountInformationTitle = By.XPath("//span[@data-ui-id ='page-title-wrapper']");
        public static readonly By currentPasswordField = By.XPath("//*[@id = 'current-password']");
        public static readonly By newPasswordField = By.XPath("//*[@id = 'password']");
        public static readonly By confirmNewPasswordField = By.XPath("//*[@id = 'password-confirmation']");
        public static readonly By saveNewAccountSettingsButton = By.XPath("//button[@class = 'action save primary']");
    }
}
