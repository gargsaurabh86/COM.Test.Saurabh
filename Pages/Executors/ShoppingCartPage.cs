namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;

    public class ShoppingCartPage : ShoppingCartPageLocators
    {
        readonly SignInPage signInPage;
        private readonly IWebDriver Driver;
        readonly DriverHelper driverHelper;

        public ShoppingCartPage(IWebDriver driver)
        {
            Driver = driver;
            driverHelper = new DriverHelper(Driver);
            signInPage = new SignInPage(Driver);
        }
        internal void ProceedToSignInStep()
        {
            driverHelper.WaitForElementToBeClickableAndClick(SummaryProceedToCheckoutButton);
        }

        internal void ProceedToAddressCheckStep()
        {
            signInPage.SigninAsValidRegisteredCustomer();
        }

        internal void ProceedToShippingStep()
        {
            driverHelper.WaitForElementToBeClickableAndClick(AddressProceedToCheckoutButton);
        }

        internal void AcceptTermsAndProceedToPayment()
        {
            driverHelper.WaitForElementToBeClickableAndClick(ShippingTermsOfServiceCheckBox);
            driverHelper.WaitForElementToBeClickableAndClick(ShippingProceedToCheckoutButton);
        }

        internal void NavigateToOrderHistoryPage()
        {
            driverHelper.WaitForElementToBeClickableAndClick(BackToOrderLink);
        }

        internal void PaymentByBankWire()
        {
            driverHelper.WaitForElementToBeClickableAndClick(PaymentByBankWireButton);
        }

        internal void ConfirmOrder()
        {
            driverHelper.WaitForElementToBeClickableAndClick(OrderConfirmationButton);
        }
    }
}
