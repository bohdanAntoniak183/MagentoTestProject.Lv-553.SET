using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Components;
using OpenQA.Selenium;
using MagentoLv553SET.Containers;
using MagentoLv553SET.Util;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Pages
{
    class ShoppingCartPage : AMenuPart
    {
        public ShoppingCartPageProductContainer ProductContainer
        { 
            get
            {
                return new ShoppingCartPageProductContainer(driver);
            }
        }

        public IWebElement TotalPriceTitle
        { 
            get
            {
                return new PropertyGetters(driver).GetVisibleWebElement(ShoppingCartPageMap.totalPriceTitleMap);
            }
        }

        public ShoppingCartPage(IWebDriver driver) : base(driver)
        {

        }

        public string GetTotalPriceTitleText()
        {
            return TotalPriceTitle.Text;
        }

        public void ClickOnRemoveProductButton(string productName)
        {
            new PropertyGetters(driver).GetClickableWebElement(ShoppingCartPageMap
                .GetRemoveButtonByName(productName)).Click();
        }
    }
}
