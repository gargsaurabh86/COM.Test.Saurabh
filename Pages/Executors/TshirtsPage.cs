namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;

    public class TshirtsPage : TshirtsPageLocators
    {
        private IWebDriver Driver;
        readonly DriverHelper driverHelper;

        public TshirtsPage(IWebDriver driver)
        {
            Driver = driver;
            driverHelper = new DriverHelper(Driver);
        }
        internal void AddTShirtToCart()
        {
            driverHelper.WaitForElementToBeClickableAndClick(AddToCartButton);
        }

        internal void ProceedToCheckOutJourney()
        {
            driverHelper.WaitForElementToBeClickableAndClick(OverLayProceedToCheckOutButton);
        }
    }
}
