using MagentoLv553SET.Components;
using MagentoLv553SET.Maps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Pages
{
    class EditAccountInformationPage : AMenuPart
    {
        public EditAccountInformationPage(IWebDriver webDriver) : base(webDriver)
        {

        }      

        public IWebElement EditAccountInformationTitle
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(EditAccountInformationPageMap.editAccountInformationTitle));
                return driver.FindElement(EditAccountInformationPageMap.editAccountInformationTitle);
            }
        }
        public IWebElement CurrentPasswordField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(EditAccountInformationPageMap.currentPasswordField));
                return driver.FindElement(EditAccountInformationPageMap.currentPasswordField);
            }
        }

        public IWebElement NewPasswordField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(EditAccountInformationPageMap.newPasswordField));
                return driver.FindElement(EditAccountInformationPageMap.newPasswordField);
            }
        }
        public IWebElement ConfirmNewPasswordField
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(EditAccountInformationPageMap.confirmNewPasswordField));
                return driver.FindElement(EditAccountInformationPageMap.confirmNewPasswordField);
            }
        }
        
        public IWebElement SaveNewAccountSettingsButton
        {
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(EditAccountInformationPageMap.saveNewAccountSettingsButton));
                return driver.FindElement(EditAccountInformationPageMap.saveNewAccountSettingsButton);
            }
        }

    }
}
