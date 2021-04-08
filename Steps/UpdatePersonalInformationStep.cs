namespace COM.Test.SaurabhGarg.Steps
{
    using COM.Test.SaurabhGarg.Drivers;
    using COM.Test.SaurabhGarg.Pages.Executors;
    using NUnit.Framework;
    using TechTalk.SpecFlow;

    [Binding]
    public sealed class UpdatePersonalInformationStep
    {
        readonly HomePage homePage;
        readonly SignInPage signInPage;
        readonly MyAccountPage myAccountPage;
        readonly YourPersonalInformationPage yourPersonalInformationPage;

        private readonly WebDriver _webDriver;

        public UpdatePersonalInformationStep(WebDriver webDriver)
        {
            _webDriver = webDriver;
            homePage = new HomePage(_webDriver.Driver);
            signInPage = new SignInPage(_webDriver.Driver);
            myAccountPage = new MyAccountPage(_webDriver.Driver);
            yourPersonalInformationPage = new YourPersonalInformationPage(_webDriver.Driver);
        }


        [Given(@"I am on your personal information page")]
        public void GivenIAmOnYourPersonalInformationPage()
        {
            homePage.NavigateToShoppingWebsite();
            homePage.NavigateToSignInPage();
            signInPage.SigninAsValidRegisteredCustomer();
            myAccountPage.NavigateToMyPersonalinformationPage();
        }

        [Given(@"I enter new valid first name")]
        public void GivenIEnterNewValidFirstName()
        {
            yourPersonalInformationPage.EnterFirstName();
        }

        [When(@"I save it")]
        public void WhenISaveIt()
        {
            yourPersonalInformationPage.ClickSaveButton();
        }

        [Given(@"I enter current and new password")]
        public void GivenIEnterCurrentAndNewPassword()
        {
            yourPersonalInformationPage.EnterCurrentAndNewPassword();
        }

        [Then(@"Personal information updated successfully message is displayed")]
        public void ThenPersonalInformationUpdatedSuccessfullyMessageIsDisplayed()
        {
            Assert.IsTrue(yourPersonalInformationPage.IsSuccessfullMessageDisplayed());
        }
    }
}
