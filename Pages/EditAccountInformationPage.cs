using MagentoLv553SET.Components;
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

        public IWebElement EditAccountInformationTitle => PropertyGetters.
            GetVisibleWebElement(EditAccountInformationPageMap.editAccountInformationTitle, driver);

        public IWebElement CurrentPasswordField => PropertyGetters.
            GetVisibleWebElement(EditAccountInformationPageMap.currentPasswordField, driver);

        public IWebElement NewPasswordField => PropertyGetters.
            GetVisibleWebElement(EditAccountInformationPageMap.newPasswordField, driver);

        public IWebElement ConfirmNewPasswordField => PropertyGetters.
            GetVisibleWebElement(EditAccountInformationPageMap.confirmNewPasswordField, driver);

        public IWebElement SaveNewAccountSettingsButton => PropertyGetters.
            GetClickableWebElement(EditAccountInformationPageMap.saveNewAccountSettingsButton, driver);        

    }
}
