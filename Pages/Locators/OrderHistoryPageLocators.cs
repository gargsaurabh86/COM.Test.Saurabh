namespace COM.Test.SaurabhGarg.Pages.Locators
{
    using OpenQA.Selenium;
    public class OrderHistoryPageLocators
    {
        public By OrderReferenceLink => By.XPath("//table[@id='order-list']//tr[1]/td[1]/a");

        public By OrderTotalPrice => By.XPath("//table[@id='order-list']//tr[1]/td[3]/span[1]");
    }
}
