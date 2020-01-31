using System;
using OpenQA.Selenium;

namespace UI.Pages.Base
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;

        protected Uri Url;
        protected string PageName;

        protected BasePage(string name, string url = null)
        {
            PageName = name;
            if (url != null)
                Url = new Uri(url);

            Driver = UI.Driver.Driver.GetDriver();
        }

        protected virtual void OpenPage(params string[] parameters)
        {
            string finalUrl;
            if (parameters.Length != 0)
            { finalUrl = string.Format(Url.ToString(), parameters); }
            else { finalUrl = Url.ToString(); }
            Driver.Navigate().GoToUrl(finalUrl);
        }

        public void OpenPage()
        {
            Driver.Navigate().GoToUrl(Url);
        }
    }
}
