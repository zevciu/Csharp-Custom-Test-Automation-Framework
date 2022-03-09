using System.Configuration;
using CsharpSelenium.utilities;
using NUnit.Framework;
using OpenQA.Selenium;


namespace CsharpSelenium.tests
{
    public abstract class BaseTest
    {
        public static IWebDriver driver;
        protected static ScreenshotHelper screenshot;
        protected static ReportHelper extent;
        protected static GeneratorTool generate;
        protected string sspath;
        

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            extent = new ReportHelper();
        }

        [SetUp]
        public void SetUp()
        {
            extent.CreateTest(TestContext.CurrentContext.Test.Name);

            screenshot = new ScreenshotHelper();
            generate = new GeneratorTool();
         
            driver = new WebDriverFactory().GetDriver(extent);
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
            extent.StepStatusPass("Browser navigated to " + ConfigurationManager.AppSettings["URL"]);
        }

        [TearDown]

        public void TearDown()
        {
            extent.AttachScreenshotToReport(driver, screenshot, sspath);
            driver.Quit();
            extent.StepStatusPass("Browser closed.");
        }

        [OneTimeTearDown]

        public void OneTimeTearDown()
        {
            extent.CloseReport();
        }

    }

}
