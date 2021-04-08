namespace COM.Test.SaurabhGarg.Pages.Locators
{
    using OpenQA.Selenium;
    public class HomePageLocators
    {
        public By SignInLink => By.ClassName("login");

        public By TshirtMenulink => By.XPath("//*[@id='block_top_menu']/ul/li/a[(text() ='T-shirts')]");
    }
}
