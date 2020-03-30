using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TechTalk.SpecFlow;
using UI;
using UI.Driver;
using AllureLifecycle = Allure.Commons.AllureLifecycle;

namespace Tests.StepDefinitions
{
    public class BaseTest
    {
        [BeforeScenario]
        public void SetUp()
        {
            Configuration.Configure();
            Driver.SetDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                AllureLifecycle.Instance.AddAttachment("Failure Screenshot", "image/jpeg", Driver.TakeScreenshot().AsByteArray, "jpeg");
            }

            Driver.Quit();
        }
    }
}
