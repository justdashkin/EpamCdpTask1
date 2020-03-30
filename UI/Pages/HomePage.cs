using OpenQA.Selenium;
using UI.Pages.Base;
using UI.WrappedElements;

namespace UI.Pages
{
    public class HomePage : BasePage
    {
        public HomePage() : base("Home Page", Configuration.EpamHost)
        {
        }

        public new HomePage OpenPage()
        {
            base.OpenPage();
            return this;
        }

        public WebElement HomePageLogo = new WebElement(By.XPath("//img[@class='header__logo12']"), "Home Page Logo");
    }
}
