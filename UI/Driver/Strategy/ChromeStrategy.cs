using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using WebDriverManager;
using WebDriverManager.DriverConfigs;
using WebDriverManager.DriverConfigs.Impl;

namespace UI.Driver.Strategy
{
    public class ChromeStrategy
    {
        private readonly IDriverConfig _config = new ChromeConfig();

        public void SetUpDriverConfig()
        {
            new DriverManager().SetUpDriver(_config);
        }

        public IWebDriver /*RemoteWebDriver*/ GetDriverInstance()
        {
            var baseChromeOptions = new ChromeOptions();

            baseChromeOptions.AddArgument("no-sandbox");
            baseChromeOptions.AddArgument("--disable-notifications");
            baseChromeOptions.AddArgument("--start-maximized");
            baseChromeOptions.AddUserProfilePreference("intl.accept_languages", "nl");
            baseChromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            //baseChromeOptions.AddAdditionalCapability("enableLog", true, true);
            //baseChromeOptions.AddAdditionalCapability("enableVideo", true, true);
            return new ChromeDriver(Directory.GetCurrentDirectory(), baseChromeOptions, TimeSpan.FromMinutes(10));
        }

        public IDriverConfig GetDriverConfig()
        {
            return _config;
        }
    }
}
