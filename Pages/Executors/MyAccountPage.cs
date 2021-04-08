namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;

    public class MyAccountPage : MyAccountPageLocators
    {
        private IWebDriver Driver;
        readonly DriverHelper driverHelper;

        public MyAccountPage(IWebDriver driver)
        {
            Driver = driver;
            driverHelper = new DriverHelper(Driver);
        }
        internal void NavigateToMyPersonalinformationPage()
        {
            driverHelper.WaitForElementToBeClickableAndClick(this.MyPersonalInformationbutton);
        }
    }
}
