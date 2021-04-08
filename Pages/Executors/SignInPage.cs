namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;
    using System.Configuration;

    public class SignInPage : SignInPageLocators
    {
        private readonly IWebDriver Driver;
        readonly DriverHelper driverHelper;

        public SignInPage(IWebDriver driver)
        {
            Driver = driver;
            driverHelper = new DriverHelper(Driver);
        }
        private void EnterAlreadyRegisteredUserEmailAddress()
        {
            driverHelper.EnterTextWithWait(this.AlreadyRegisteredUserEmailAddressInput, ConfigurationManager.AppSettings["RegisteredEmailAddress"]);
        }

        private void EnterAlreadyRegisteredUserPassword()
        {
            driverHelper.EnterTextWithWait(this.AlreadyRegisteredUserPasswordInput, ConfigurationManager.AppSettings["ValidPassword"]);
        }

        public void SigninAsValidRegisteredCustomer()
        {
            EnterAlreadyRegisteredUserEmailAddress();
            EnterAlreadyRegisteredUserPassword();
            driverHelper.WaitForElementToBeClickableAndClick(this.SignInButton);
        }
    }
}
