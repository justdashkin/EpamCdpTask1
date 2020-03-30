using System.Threading;
using OpenQA.Selenium;
using UI.Driver.Strategy;

namespace UI.Driver
{
    public class Driver
    {
        private static readonly ThreadLocal<IWebDriver> DriverInstances = new ThreadLocal<IWebDriver>();

        public static IWebDriver GetDriver()
        {
            return DriverInstances.Value;
        }

        public static void SetDriver()
        {
            DriverInstances.Value = new ChromeStrategy().GetDriverInstance();
        }

        public static void Quit()
        {
            DriverInstances.Value?.Quit();
        }

        public static Screenshot TakeScreenshot() => ((ITakesScreenshot)GetDriver()).GetScreenshot();
    }
}
