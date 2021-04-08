namespace COM.Test.SaurabhGarg.Pages.Locators
{
    using OpenQA.Selenium;
    public class OrderHistoryPageLocators
    {
        public By OrderReferenceLink => By.XPath("//table[@id='order-list']//tr[1]/td[1]/a");

        public By ProductOrderedDescription => By.XPath("//div[@id='order-detail-content']/table/tbody/tr/td[2]/label");
    }
}
