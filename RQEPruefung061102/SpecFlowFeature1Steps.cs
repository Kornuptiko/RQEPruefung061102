using System;
using TechTalk.SpecFlow;
using Xunit;

namespace RQEPruefung0611
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        string num;
        int ans;

        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(string p0)
        {
            num = p0;
        }

        [When(@"you convert it from hex to int")]
        public void WhenYouConvertItFromHexToInt()
        {
            ans = System.Convert.ToInt32(num, 16);
        }

        [When(@"you convert it from oct to int")]
        public void WhenYouConvertItFromOctToInt()
        {
            ans = System.Convert.ToInt32(num, 8);
        }

        [When(@"you convert it from bin to int")]
        public void WhenYouConvertItFromBinToInt()
        {
            ans = System.Convert.ToInt32(num, 2);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = p0;
            var actual = ans;

            Assert.Equal(expected, actual);
        }
    }
}
