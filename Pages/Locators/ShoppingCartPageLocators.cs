namespace COM.Test.SaurabhGarg.Pages.Locators
{
    using OpenQA.Selenium;
    public class ShoppingCartPageLocators
    {
        public By SummaryProceedToCheckoutButton => By.XPath("//*[@id='center_column']//a[@title='Proceed to checkout']");
        public By AddressProceedToCheckoutButton => By.XPath("//*[@name='processAddress']");
        public By ShippingProceedToCheckoutButton => By.XPath("//button[@name='processCarrier']");
        public By ShippingTermsOfServiceCheckBox => By.XPath("//*[@id='form']/div/p[2]/label");
        public By PaymentByBankWireButton => By.PartialLinkText("Pay by bank wire");
        public By OrderConfirmationButton => By.XPath("//span[contains(text(),'I confirm my order')]");
        public By BackToOrderLink => By.XPath("//a[contains(text(),'Back to orders')]");
    }
}
