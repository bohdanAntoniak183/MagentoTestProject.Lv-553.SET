using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using MagentoLv553SET.Maps;
using MagentoLv553SET.Util;

namespace MagentoLv553SET.Components
{
    class AOptionsForProductComponent : AMenuPart
    {
        public AOptionsForProductComponent(IWebDriver webDriver) : base(webDriver)
        {

        }

        public IWebElement AddToWishListButton => new PropertyGetters(driver).GetVisibleWebElement(AOptionsForProductComponentMap.addToWishListButton);

       
       
      
        public void ClickOnAddToWishListButton()
        {
            AddToWishListButton.Click();
        }

      
    }
}
