namespace COM.Test.SaurabhGarg.Pages.Locators
{
    using OpenQA.Selenium;
    public class TshirtsPageLocators
    {
        public By AddToCartButton => By.XPath("//span[contains(text(),'Add to cart')]");
        public By OverLayProceedToCheckOutButton => By.XPath("//span[contains(text(),'Proceed to checkout')]");
    }
}
