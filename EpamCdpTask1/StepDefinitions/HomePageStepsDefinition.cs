using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using TechTalk.SpecFlow;
using UI;
using UI.Driver;
using UI.Pages;

namespace Tests.StepDefinitions
{
    [Binding]
    public class HomePageStepsDefinition: BaseTest
    {
        private HomePage _homePage;

        [Given(@"I open EPAM home page")]
        public void GivenIOpenEPAMHomePage()
        {

            _homePage = new HomePage().OpenPage();
            
            Assert.True(_homePage.HomePageLogo.IsPresent(), "Home Page logo is not present");
        }

        [Then(@"I verify home logo is present")]
        public void ThenIVerifyHomeLogoIsPresent()
        {
            Assert.True(_homePage.HomePageLogo.IsPresent(), "Home Page logo is not present");
            Driver.Quit();
        }


    }
}
