namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;
    using Resources;

    public class OrderHistoryPage : OrderHistoryPageLocators
    {
        private IWebDriver Driver;
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

        internal bool? VerifyOrderDetails()
        {
            return driverHelper.GetText(OrderTotalPrice) == Constant.OrderTotalPrice;
        }
    }
}
