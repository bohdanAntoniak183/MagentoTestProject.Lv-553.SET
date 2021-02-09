using OpenQA.Selenium;

namespace MagentoLv553SET.Maps
{
    public sealed class HomePageMap
    {
        public static readonly By mainSignInButton = By.XPath("//a[contains(@href,'/account/login')]");
        public static readonly By createAnAccountButton = By.XPath("//a[contains(@href,'/account/create')]");

        private HomePageMap()
        {
        }
    }
}
