using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Data;

namespace MagentoLv553SET.Tests
{
    public class BaseTest
    {
        protected IWebDriver webDriver;

        [SetUp]
        protected void DoBeforeEachTest()
        {
            webDriver.Manage().Cookies.DeleteAllCookies();
            webDriver.Navigate().GoToUrl(Urls.basePageUrl);
            webDriver.Manage().Timeouts().PageLoad =
                TimeSpan.FromSeconds(10);
        }

        [OneTimeSetUp]
        protected void DoBeforeAllTests()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--no-proxy-server");
            option.AddArgument("-start-maximized");
            webDriver = new ChromeDriver(option);
        }

        [TearDown]
        protected void DoAfterEachTest()
        {
            webDriver.Quit();
        }
    }
}
