using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagentoLv553SET.Pages
{
    class MyAccountPage : HomePage
    {
        public MyAccountPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement ClearCompareProductsList => new PropertyGetters(driver).
            GetClickableWebElement(MyAccountPageMap.clearCompareProductsList);

        public IWebElement MyAccountCompareButton => new PropertyGetters(driver).
            GetVisibleWebElement(MyAccountPageMap.myAccountCompareButton);

        public IWebElement RemovedCompareProductMessage => new PropertyGetters(driver).
            GetVisibleWebElement(MyAccountPageMap.removedCompareProductMessage);

        public IWebElement CompareProductDeleteButton => new PropertyGetters(driver).
            GetClickableWebElement(MyAccountPageMap.compareProductDeleteButton);

        public IWebElement ClearedListMessage => new PropertyGetters(driver).
            GetVisibleWebElement(MyAccountPageMap.clearedListMessage);

        public IWebElement QuestionMessage => new PropertyGetters(driver).
            GetVisibleWebElement(MyAccountPageMap.questionMessage);
    }
}
