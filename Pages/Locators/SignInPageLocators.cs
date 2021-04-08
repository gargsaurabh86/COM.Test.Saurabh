namespace COM.Test.SaurabhGarg.Pages.Locators
{
    using OpenQA.Selenium;

    public class SignInPageLocators
    {
        public By AlreadyRegisteredUserEmailAddressInput => By.Id("email");
        public By AlreadyRegisteredUserPasswordInput => By.Id("passwd");
        public By SignInButton => By.Id("SubmitLogin");
    }
}
