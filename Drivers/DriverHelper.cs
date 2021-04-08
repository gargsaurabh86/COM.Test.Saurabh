namespace COM.Test.SaurabhGarg.Drivers
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;
    public class DriverHelper : WebDriver
    {
        private new readonly IWebDriver Driver;

        public DriverHelper(IWebDriver driver)
        {
            Driver = driver;
        }

        private void WaitForElementsToBeVisible(By locator, int waitDuration = 15)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitDuration));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
        }

        private void WaitForElementToBeClickable(By locator, int waitDuration = 15)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitDuration));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        private void Click(By locator)
        {
            Driver.FindElement(locator).Click();
        }

        public void WaitForElementToBeClickableAndClick(By locator, int waitDuration = 15)
        {
            WaitForElementToBeClickable(locator);
            this.Click(locator);
        }

        public void EnterTextWithWait(By locator, string text)
        {
            WaitForElementToBeClickable(locator);
            Driver.FindElement(locator).Clear();
            Driver.FindElement(locator).SendKeys(text);
        }

        public void NavigateToURL(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public bool? IsLinkPresentOnPage(By signOutLink)
        {
            return Driver.FindElement(signOutLink).Displayed;
        }

        public string GetText(By locator)
        {
            WaitForElementsToBeVisible(locator);
            return Driver.FindElement(locator).Text;
        }
    }
}
