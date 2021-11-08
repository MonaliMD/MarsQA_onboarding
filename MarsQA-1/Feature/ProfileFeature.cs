using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class ProfileSteps : Driver
    {
        
        //SignIn signInObj = new SignIn();

        [Given(@"I am in my Profile page")]
        public void GivenIAmInMyProfilePage()
        {
            SignIn.SigninStep();
        }

        [When(@"Seller enter First Name as ""(.*)"" and Last Name as ""(.*)""")]
        public void WhenSellerEnterFirstNameAsAndLastNameAs(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Name sold be displayed ad ""(.*)""")]
        public void ThenNameSoldBeDisplayedAd(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
