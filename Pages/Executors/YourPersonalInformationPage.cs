namespace COM.Test.SaurabhGarg.Pages.Executors
{
    using Drivers;
    using OpenQA.Selenium;
    using Pages.Locators;
    using Resources;
    using System.Configuration;

    public class YourPersonalInformationPage : YourPersonalInformationPageLocators
    {
        private readonly IWebDriver Driver;
        readonly DriverHelper driverHelper;

        public YourPersonalInformationPage(IWebDriver driver)
        {
            Driver = driver;
            driverHelper = new DriverHelper(Driver);
        }
        public void EnterFirstName()
        {
            //One can randomly generate any string for first name using Faker library

            driverHelper.EnterTextWithWait(FirstnameInput, Constant.NewFirstName);
        }

        public void EnterCurrentPassword()
        {
            driverHelper.EnterTextWithWait(CurrentPasswordInput, ConfigurationManager.AppSettings["ValidPassword"]);
        }

        public void EnterNewAndConfirmationPassword()
        {
            // Used existing password as there was no validation in website

            driverHelper.EnterTextWithWait(NewPasswordInput, ConfigurationManager.AppSettings["ValidPassword"]);
            driverHelper.EnterTextWithWait(ConfirmationPasswordInput, ConfigurationManager.AppSettings["ValidPassword"]);
        }

        internal void ClickSaveButton()
        {
            driverHelper.WaitForElementToBeClickableAndClick(this.SaveButton);
        }

        internal bool? IsSuccessfullMessageDisplayed()
        {
            return driverHelper.GetText(this.SuccessfullMesageText) == Constant.FirstNameUpdatedSucessfullyMessage;
        }

        internal void EnterCurrentAndNewPassword()
        {
            this.EnterCurrentPassword();
            this.EnterNewAndConfirmationPassword();
        }
    }
}