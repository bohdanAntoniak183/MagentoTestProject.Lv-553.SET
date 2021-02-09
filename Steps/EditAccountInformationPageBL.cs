using MagentoLv553SET.Data;
using MagentoLv553SET.Pages;
using OpenQA.Selenium;

namespace MagentoLv553SET.Steps
{
    class EditAccountInformationPageBL : HomePageBL

    {
        private readonly EditAccountInformationPage editAccountInformationPage;
        private static readonly string currentPassword = RegistrationPageBL.randomPassword;
        private static readonly string randomNewPassword = TestsDataGenerator.GenerateRandomPassword(10);
        


        public EditAccountInformationPageBL(IWebDriver webDriver) : base(webDriver)
        {
            editAccountInformationPage = new EditAccountInformationPage(webDriver);
        }
        public EditAccountInformationPageBL ChangePassword()
        {
            InputCurrentPasswordField();
            InputNewPasswordField();
            InputConfirmNewPasswordField();
            ClickOnSaveNewAccountSettingsButton();

            return new EditAccountInformationPageBL(webDriver);

        }

        public void ClickOnEditAccountInformationTitle()
        {
            editAccountInformationPage.EditAccountInformationTitle.Click();
        }

        public string GetEditAccountInformationTitleText()
        {
            return editAccountInformationPage.EditAccountInformationTitle.Text;
        }
        

        public void InputCurrentPasswordField()
        {
            editAccountInformationPage.CurrentPasswordField.Clear();
            editAccountInformationPage.CurrentPasswordField.SendKeys(currentPassword);
        }
        public void InputNewPasswordField()

        {
            editAccountInformationPage.NewPasswordField.Clear();
            editAccountInformationPage.NewPasswordField.SendKeys(randomNewPassword);
        }
                

        public void InputConfirmNewPasswordField()
        {
            editAccountInformationPage.ConfirmNewPasswordField.Clear();
            editAccountInformationPage.ConfirmNewPasswordField.SendKeys(randomNewPassword);
        }


        public void ClickOnSaveNewAccountSettingsButton()
        {
            editAccountInformationPage.SaveNewAccountSettingsButton.Click();
        }
        public string GetEditAccountTitle()
        {
            string myAccountTitle = editAccountInformationPage.EditAccountInformationTitle.Text;
            return myAccountTitle;
        }
        

    }

}
