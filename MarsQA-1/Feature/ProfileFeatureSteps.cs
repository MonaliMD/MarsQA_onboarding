using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ProfileFeatureSteps
    {
        [Given(@"I go the website url")]
        public void GivenIGoTheWebsiteUrl()
        {
            System.Diagnostics.Debug.WriteLine("test1");
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on login button")]
        public void GivenIClickOnLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter my valid '(.*)' and '(.*)' and click on login button")]
        public void WhenIEnterMyValidAndAndClickOnLoginButton(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Then I should be able to see my name on the page")]
        public void ThenThenIShouldBeAbleToSeeMyNameOnThePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
