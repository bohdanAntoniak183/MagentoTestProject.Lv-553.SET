using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using System;

namespace MagentoLv553SET.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
    }
}
