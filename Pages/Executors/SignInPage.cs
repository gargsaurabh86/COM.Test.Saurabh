namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;
    using Resources;

    public class SignInPage : SignInPageLocators
    {
        private IWebDriver Driver;
        readonly DriverHelper driverHelper;

        public SignInPage(IWebDriver driver)
        {
            Driver = driver;
            driverHelper = new DriverHelper(Driver);
        }
        private void EnterAlreadyRegisteredUserEmailAddress()
        {
            driverHelper.EnterTextWithWait(this.AlreadyRegisteredUserEmailAddressInput, Constant.RegisteredEmailAddress);
        }

        private void EnterAlreadyRegisteredUserPassword()
        {
            driverHelper.EnterTextWithWait(this.AlreadyRegisteredUserPasswordInput, Constant.ValidPassword);
        }

        public void SigninAsValidRegisteredCustomer()
        {
            EnterAlreadyRegisteredUserEmailAddress();
            EnterAlreadyRegisteredUserPassword();
            driverHelper.WaitForElementToBeClickableAndClick(this.SignInButton);
        }
    }
}
