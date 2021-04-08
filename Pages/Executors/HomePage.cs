namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;
    using Resources;

    public class HomePage : HomePageLocators
    {
        private IWebDriver Driver;
        readonly DriverHelper driverHelper;

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
            driverHelper = new DriverHelper(Driver);
        }

        internal void NavigateToShoppingWebsite()
        {
            driverHelper.NavigateToURL(Constant.Website);
        }

        internal void NavigateToSignInPage()
        {
            driverHelper.WaitForElementToBeClickableAndClick(SignInLink);
        }

        internal void NavigateToTshirtsTab()
        {
            driverHelper.WaitForElementToBeClickableAndClick(TshirtMenulink);
        }
    }
}
