namespace COM.Test.SaurabhGarg.Pages.Locators
{
    using OpenQA.Selenium;

    public class YourPersonalInformationPageLocators
    {
        public By FirstnameInput => By.Id("firstname");
        public By CurrentPasswordInput => By.Id("old_passwd");
        public By NewPasswordInput => By.Id("passwd");
        public By ConfirmationPasswordInput => By.Id("confirmation");
        public By SaveButton => By.Name("submitIdentity");
        public By SuccessfullMesageText => By.CssSelector(".alert.alert-success");
    }
}
