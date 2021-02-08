using MagentoLv553SET.Components;
using MagentoLv553SET.Data;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;
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

        public IWebElement EditAccountInformationTitle => new PropertyGetters(driver).
            GetVisibleWebElement(EditAccountInformationPageMap.editAccountInformationTitle);

        public IWebElement CurrentPasswordField => new PropertyGetters(driver).
            GetVisibleWebElement(EditAccountInformationPageMap.currentPasswordField);

        public IWebElement NewPasswordField => new PropertyGetters(driver).
            GetVisibleWebElement(EditAccountInformationPageMap.newPasswordField);

        public IWebElement ConfirmNewPasswordField => new PropertyGetters(driver).
            GetVisibleWebElement(EditAccountInformationPageMap.confirmNewPasswordField);

        public IWebElement SaveNewAccountSettingsButton => new PropertyGetters(driver).
            GetClickableWebElement(EditAccountInformationPageMap.saveNewAccountSettingsButton);       

    }
}
