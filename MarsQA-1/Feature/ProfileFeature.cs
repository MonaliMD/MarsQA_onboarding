using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Specflow_task1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    
    [Binding]
    public class ProfileSteps : Driver
    {

        Profile_page profileObj = new Profile_page();

        [Given(@"I am in my Profile page")]
        public void GivenIAmInMyProfilePage()
        {
            SignIn.SigninStep();
        }

        [When(@"Seller enter '(.*)' and '(.*)'")]
        public void WhenSellerEnterAnd(string p0, string p1)
        {
            profileObj.updateName(driver ,p0, p1);
        }


        [Then(@"Name sold be displayed ad ""(.*)""")]
        public void ThenNameSoldBeDisplayedAd(string p0)
        {
            string newProfileName = profileObj.getProfileName(driver);
            Assert.That(newProfileName == "Ann Johns", "Login failed.");
        }
    }
}
