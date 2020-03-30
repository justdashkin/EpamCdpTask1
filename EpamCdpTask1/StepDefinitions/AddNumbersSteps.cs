using Core;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using System.Collections.Generic;

namespace Tests.StepDefinitions
{

    [Binding]
    public class AddNumbersSteps
    {
        private List<int> _numbers;

        [When(@"I get numbers from ""(.*)""")]
        public void WhenIGetNumbers(string dataProviderType)
        {
            _numbers = dataProviderType switch
            {
                "Excel" => ExcelHelper.GetDataFormFile("Book1.xlsx"),
                "DB" => DbHelper.GetDataFromDb(),
                _ => _numbers
            };
        }

        [When(@"I add ""(.*)"" and ""(.*)""")]
        public void WhenIAddAnd(int number1, int number2)
        {
            _numbers = new List<int> {number1, number2};
        }


        [When(@"I calculate their sum")]
        public int WhenICalculateTheirSum() => _numbers.Sum();

        [Then(@"I verify the sum is (.*)")]
        public void ThenIVerifyTheSumIs(int expectedSum)
        {
            Assert.AreEqual(WhenICalculateTheirSum(), expectedSum);
        }
    }
}
