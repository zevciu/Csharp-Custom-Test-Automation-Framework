using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace CsharpSelenium.utilities
{
    public class WebDriverFactory
    {  
        private ReportHelper extentReportHelper;
        public IWebDriver GetDriver(ReportHelper reportHelper)     
        {
            extentReportHelper = reportHelper;

            if (ConfigurationManager.AppSettings["browser"] == "CHROME")
            {
                IWebDriver driver = new ChromeDriver(PathConfiguration.DRIVERS_PATH);
                extentReportHelper.StepStatusPass("Browser started.");
                driver.Manage().Window.Maximize();
                extentReportHelper.StepStatusPass("Browser maximized.");
                return driver;
            }
    
             else if (ConfigurationManager.AppSettings["browser"] == "FIREFOX")           
            {
                IWebDriver driver = new FirefoxDriver(PathConfiguration.DRIVERS_PATH + "geckodriver.exe");
                extentReportHelper.StepStatusPass("Browser started.");
                driver.Manage().Window.Maximize();
                extentReportHelper.StepStatusPass("Browser maximized.");
                return driver;
            }

             else if (ConfigurationManager.AppSettings["browser"] == "EDGE")          
            {
                IWebDriver driver = new EdgeDriver(PathConfiguration.DRIVERS_PATH + "msedgedriver.exe");
                extentReportHelper.StepStatusPass("Browser started.");
                driver.Manage().Window.Maximize();
                extentReportHelper.StepStatusPass("Browser maximized.");
                return driver;
            }

             else if (ConfigurationManager.AppSettings["browser"] == "OPERA")
            {
                IWebDriver driver = new EdgeDriver(PathConfiguration.DRIVERS_PATH + "operadriver.exe");
                extentReportHelper.StepStatusPass("Browser started.");
                driver.Manage().Window.Maximize();
                extentReportHelper.StepStatusPass("Browser maximized.");
                return driver;
            }

            return null;
        }

    }
}
