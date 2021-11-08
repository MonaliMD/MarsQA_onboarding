using MarsQA_1.Pages;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    //SignIn signInObj = new SignIn();
    [Binding]
    class Login
    {

        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            SignIn.SigninStep();
        }

    }
}
