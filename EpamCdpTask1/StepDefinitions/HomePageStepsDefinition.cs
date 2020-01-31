using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration;
using UI;
using UI.Driver;
using UI.Pages;

namespace Tests.StepDefinitions
{
    [Binding]
    public class HomePageStepsDefinition
    {
        private HomePage _homePage;

        [Given(@"I open EPAM home page")]
        public void GivenIOpenEPAMHomePage()
        {
            Configuration.Configure();
            Driver.SetDriver();
            _homePage = new HomePage();
            _homePage.OpenPage();
            Assert.True(_homePage.HomePageLogo.IsPresent(), "Home Page logo is not present");
            int i = 0;
        }

        [Then(@"I verify home logo is present")]
        public void ThenIVerifyHomeLogoIsPresent()
        {
            Assert.True(_homePage.HomePageLogo.IsPresent(), "Home Page logo is not present");
            Driver.Quit();
        }
    }
}
