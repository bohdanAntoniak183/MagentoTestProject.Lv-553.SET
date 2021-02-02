using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Maps
{
    class RegistrationPageMap
    {
        public static readonly By createNewCustomerAccountTitle = By.XPath("//span[@class = 'base']");
        public static readonly By personalInformationTitle = By.XPath("//span[text()='Personal Information']");
        public static readonly By firstNameLable = By.XPath("//span[text() = 'First Name']");
        public static readonly By firstNameField = By.XPath("//*[@id='firstname']");
        public static readonly By lastNameLable = By.XPath("//span[text() = 'Last Name']");
        public static readonly By lastNameField = By.XPath("//*[@id='lastname']");
        public static readonly By signInInformationTitle = By.XPath("//span[text() = 'Sign-in Information']");
        public static readonly By emailAddressLable = By.XPath("//span[text() = 'Email']");
        public static readonly By emailAddressField = By.XPath("//*[@id='email_address']");
        public static readonly By passwordLable = By.XPath("//span[text()='Password']");
        public static readonly By passwordField = By.XPath("//*[@id='password']");
        public static readonly By confirmPasswordLable = By.XPath("//span[text()='Confirm Password']");
        public static readonly By passwordControl = By.XPath("//*[@id = 'password-strength-meter']");
        public static readonly By confirmPasswordField = By.XPath("//*[@id='password-confirmation']");
        public static readonly By signUpForNewslettersCheckbox = By.XPath("//*[@id='is_subscribed']");
        public static readonly By submitRegistration = By.XPath("//button[@class='action submit primary']");
    }
}
