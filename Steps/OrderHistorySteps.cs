namespace COM.Test.SaurabhGarg.Steps
{
    using Drivers;
    using Pages.Executors;
    using NUnit.Framework;
    using TechTalk.SpecFlow;

    [Binding]
    public class OrderHistorySteps
    {
        readonly HomePage homePage;
        readonly TshirtsPage tshirtsPage;
        readonly ShoppingCartPage shoppingCartPage;
        readonly OrderHistoryPage orderHistoryPage;

        private WebDriver _webDriver;

        public OrderHistorySteps(WebDriver webDriver)
        {
            _webDriver = webDriver;
            homePage = new HomePage(_webDriver.Driver);
            tshirtsPage = new TshirtsPage(_webDriver.Driver);
            shoppingCartPage = new ShoppingCartPage(_webDriver.Driver);
            orderHistoryPage = new OrderHistoryPage(_webDriver.Driver);
        }

        [Given(@"I add Tshirt to the cart")]
        public void GivenIAddTshirtToTheCart()
        {
            homePage.NavigateToShoppingWebsite();
            homePage.NavigateToTshirtsTab();
            tshirtsPage.AddTShirtToCart();
            tshirtsPage.ProceedToCheckOutJourney();
        }

        [Given(@"I place order successfully")]
        public void GivenIPlaceOrderSuccessfully()
        {
            shoppingCartPage.ProceedToSignInStep();
            shoppingCartPage.ProceedToAddressCheckStep();
            shoppingCartPage.ProceedToShippingStep();
            shoppingCartPage.AcceptTermsAndProceedToPayment();
            shoppingCartPage.PaymentByBankWire();
            shoppingCartPage.ConfirmOrder();
        }

        [When(@"I navigate to order history page")]
        public void WhenINavigateToOrderHistoryPage()
        {
            shoppingCartPage.NavigateToOrderHistoryPage();
        }

        [When(@"I view last order details")]
        public void WhenIViewLastOrderDetails()
        {
            orderHistoryPage.ViewOrderDetails();
        }

        [Then(@"order details should contain '(.*)' order")]
        public void ThenOrderDetailsShouldContainOrder(string productOrdered)
        {
            Assert.IsTrue(orderHistoryPage.VerifyOrderDetails(productOrdered));
        }
    }
}
