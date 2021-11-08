using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using Specflow_task1.SpecflowPages.Pages;
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
        public void WhenSellerEnterAnd(string firstN, string lastN)
        {
            profileObj.updateName(driver , firstN, lastN);
        }


        [Then(@"Name sold be displayed ad ""(.*)""")]
        public void ThenNameSoldBeDisplayedAd(string p0)
        {
            string newProfileName = profileObj.getProfileName(driver);
            Assert.That(newProfileName == "Ann Johns", "Profile name update faild.");
        }

        //Test 02
        [When(@"Seller enter First Name as ""(.*)"" and empty the last name feild")]
        public void WhenSellerEnterFirstNameAsAndEmptyTheLastNameFeild(string firstN)
        {
            profileObj.updateFirstNameOnly(driver, firstN);
        }

       

        [Then(@"Error pop up should be displayed as First name and last name are required")]
        public void ThenErrorPopUpShouldBeDisplayedAsFirstNameAndLastNameAreRequired()
        {
            string newFirstName = profileObj.getFirstName(driver);
            Assert.That(newFirstName == "First name and last name are required", "First name update test failed");
        }

        //Add language
        
        [When(@"Seller add language as ""(.*)"" and choose level as fuent")]
        public void WhenSellerAddLanguageAsAndChooseLevelAsFuent(string language_1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pop up massage displayed as English has been added to your languages")]
        public void ThenPopUpMassageDisplayedAsEnglishHasBeenAddedToYourLanguages()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
