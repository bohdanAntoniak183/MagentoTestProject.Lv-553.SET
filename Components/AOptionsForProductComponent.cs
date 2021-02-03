using System;
using System.Collections.Generic;
using System.Text;
using MagentoLv553SET.Pages;
using OpenQA.Selenium;
using MagentoLv553SET.Maps;

namespace MagentoLv553SET.Components
{
    class AOptionsForProductComponent : AMenuPart
    {
        public AOptionsForProductComponent(IWebDriver webDriver) : base(webDriver)
        {

        }    
           
        public IWebElement AddToWishListButton
        {    
            get
            {
                wait.Until(SeleniumExtras.WaitHelpers.
                    ExpectedConditions.ElementIsVisible(AOptionsForProductComponentMap.addToWishListButton));
                return driver.FindElement(AOptionsForProductComponentMap.addToWishListButton);
            }
    
        }

        public void ClickOnAddToWishListButton()
        {
            AddToWishListButton.Click();
        }
    }
}
