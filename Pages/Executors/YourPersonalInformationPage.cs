namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;
    using Resources;

    public class YourPersonalInformationPage : YourPersonalInformationPageLocators
    {
        private IWebDriver Driver;
        readonly DriverHelper driverHelper;

        public YourPersonalInformationPage(IWebDriver driver)
        {
            Driver = driver;
            driverHelper = new DriverHelper(Driver);
        }
        public void EnterFirstName()
        {
            driverHelper.EnterTextWithWait(FirstnameInput, Constant.NewFirstName);
        }

        public void EnterCurrentPassword()
        {
            driverHelper.EnterTextWithWait(CurrentPasswordInput, Constant.ValidPassword);
        }

        public void EnterNewAndConfirmationPassword()
        {
            driverHelper.EnterTextWithWait(NewPasswordInput, Constant.ValidPassword);
            driverHelper.EnterTextWithWait(ConfirmationPasswordInput, Constant.ValidPassword);
        }

        internal void ClickSaveButton()
        {
            driverHelper.WaitForElementToBeClickableAndClick(this.SaveButton);
        }

        internal bool? IsSuccessfullMessageDisplayed()
        {
            return driverHelper.GetText(this.SuccessfullMesageText) == Constant.PersonalInformationUpdatedSucessfullyMessage;
        }

        internal void EnterCurrentAndNewPassword()
        {
            this.EnterCurrentPassword();
            this.EnterNewAndConfirmationPassword();
        }
    }
}