namespace COM.Test.SaurabhGarg.Hooks
{
    using Drivers;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using System;
    using System.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Reflection;
    using TechTalk.SpecFlow;

    [Binding]
    public class Hooks
    {
        private readonly WebDriver _webDriver;
        public Hooks(WebDriver webDriver) => _webDriver = webDriver;

        [BeforeScenario]
        public void InitialiseWebDriver()
        {
            var browserName = ConfigurationManager.AppSettings["BrowserName"].ToLower(CultureInfo.CurrentCulture);


            if (_webDriver.Driver == null)
            {
                switch (browserName)
                {
                    case "chrome":
                        ChromeOptions chromeOptions = new ChromeOptions
                        {
                            AcceptInsecureCertificates = true
                        };
                        _webDriver.Driver = new ChromeDriver(chromeOptions);
                        break;
                    case "firefox":
                        FirefoxOptions firefoxOptions = new FirefoxOptions
                        {
                            AcceptInsecureCertificates = true
                        };
                        _webDriver.Driver = new FirefoxDriver(firefoxOptions);
                        break;
                    default:
                        Console.WriteLine("No valid browser type chosen");
                        break;
                }
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseWebDriver();
        }

        [AfterStep]
        public void AfterStep(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError != null)
            {
                //Captures Screenshot

                string title = RemoveCharactersNotSupportedByWindowsFileNames(scenarioContext.StepContext.StepInfo.Text);
                string Runname = $"{title}_{DateTime.Now:yyyy-MM-dd-HH_mm_ss}";
                string filename = $"{Runname}.jpg";
                string directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                string path = $"{Path.Combine(directoryPath, filename)}";
                try
                {
                    Screenshot screenshot = ((ITakesScreenshot)_webDriver.Driver).GetScreenshot();
                    screenshot.SaveAsFile(path);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Expection occured : {1}", e.Message);
                }
            }
        }

        private static string RemoveCharactersNotSupportedByWindowsFileNames(string input)
        {
            return input.Replace(" ", "").Replace("\"", "").Replace("\\", "").Replace("/", "").Replace(":", "").Replace("*", "").Replace("?", "").Replace("<", "").Replace(">", "").Replace("'", "");
        }

        public void CloseWebDriver()
        {
            if (_webDriver.Driver != null)
            {
                _webDriver.Driver.Quit();
                _webDriver.Driver = null;
            }
        }
    }
}
