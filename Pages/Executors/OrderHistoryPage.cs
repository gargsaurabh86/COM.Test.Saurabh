namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;

    public class OrderHistoryPage : OrderHistoryPageLocators
    {
        private readonly IWebDriver Driver;
        readonly DriverHelper driverHelper;

        public OrderHistoryPage(IWebDriver driver)
        {
            Driver = driver;
            driverHelper = new DriverHelper(Driver);
        }
        internal void ViewOrderDetails()
        {
            driverHelper.WaitForElementToBeClickableAndClick(OrderReferenceLink);
        }

        internal bool? VerifyOrderDetails(string productOrdered)
        {
            return driverHelper.GetText(ProductOrderedDescription).Contains(productOrdered);
        }
    }
}
