using OpenQA.Selenium;

namespace MagentoLv553SET.Maps
{
    class HomePageMap
    {
        public static readonly By mainSignInButton = By.XPath("//a[contains(@href,'/account/login')]");

        public static readonly By fusionBackpackProduct = By.XPath("//a[contains(@href,'fusion-backpack')]");

        public static readonly By addToWishListButtonforFusionBackpackProduct = By.XPath("//a[contains(@href,'fusion-backpack')]/following-sibling::div/descendant::a[@class='action towishlist']");

        public static readonly By addToWishListButtonforPushItMessengerBagProduct = By.XPath("//a[contains(@href,'push-it-messenger-bag')]/following-sibling::div/descendant::a[@class='action towishlist']");
    }
}
