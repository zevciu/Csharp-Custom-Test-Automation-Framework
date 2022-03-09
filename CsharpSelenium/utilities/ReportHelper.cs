using System;
using System.Configuration;
using System.Runtime.InteropServices;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace CsharpSelenium.utilities
{
    public class ReportHelper
    {

        public ExtentReports extent;
        public ExtentV3HtmlReporter reporter;

        // Visual Studio will give you a warning that ExtentV3HtmlReporter has been deprecated.
        // The newest version is called ExtentHtmlReporter without the "V3". Although it has a bug. The output file name is always set to "index.html"

        public ExtentTest test;

        public ReportHelper()
        {
            extent = new ExtentReports();
            reporter = new ExtentV3HtmlReporter(PathConfiguration.REPORTS_PATH + PathConfiguration.TIMESTAMP + " " + "report.html");
            reporter.Config.ReportName = "Automation Testing Report";
            reporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extent.AttachReporter(reporter);
            extent.AddSystemInfo("Tester: ", "Aleksander Przywalny");
            extent.AddSystemInfo("Date: ", PathConfiguration.TIMESTAMP);
            extent.AddSystemInfo("Application Under Test", ConfigurationManager.AppSettings["App"]);
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Browser: ", ConfigurationManager.AppSettings["browser"]);
            extent.AddSystemInfo("Machine", Environment.MachineName);
            extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
        }

        public void CreateTest(string testName)
        {
            test = extent.CreateTest(testName);
        }

        public void TestStatusFail(string testDescription, [Optional] string path)
        {
            test.Fail(testDescription);
            test.AddScreenCaptureFromPath(path);
        }
      
        public void TestStatusSkip(string testDescription)
        {
            test.Skip(testDescription);
        }

        public void TestStatusPass(string testDescription, [Optional] string path)
        {
            test.Pass(testDescription);
            test.AddScreenCaptureFromPath(path);
        }

        public void StepStatusPass(string stepDescription)
        {
            test.Log(Status.Pass, stepDescription);
        }

        public void StepStatusWarning(string stepDescription)
        {
            test.Log(Status.Warning, stepDescription);
        }

        public void AddScreenshotFromPath(string path)
        {
            test.AddScreenCaptureFromPath(path);
        }

        public void AddScreenshotBase64(string base64ScreenCapture)
        {
            test.AddScreenCaptureFromBase64String(base64ScreenCapture);
        }

        public void AttachScreenshotToReport(IWebDriver driver, ScreenshotHelper screenshot, string sspath)
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                if (ConfigurationManager.AppSettings["screenshot"] == "ON_FAIL" || ConfigurationManager.AppSettings["screenshot"] == "ALWAYS")
                {
                    sspath = screenshot.TakeAndGivePath(driver, PathConfiguration.TIMESTAMP, TestContext.CurrentContext.Test.Name + "_FAILURE");
                }
                TestStatusFail("[TEST] " + TestContext.CurrentContext.Test.Name + " has finished with status: FAILED",
                (ConfigurationManager.AppSettings["screenshot"] == "ON_FAIL" || ConfigurationManager.AppSettings["screenshot"] == "ALWAYS" ? sspath : "")
                  );
            }

            else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Skipped)
            {
                TestStatusSkip("[TEST] " + TestContext.CurrentContext.Test.Name + " has finished with status: SKIPPED");
            }

            else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                if (ConfigurationManager.AppSettings["screenshot"] == "ALWAYS")
                {
                    sspath = screenshot.TakeAndGivePath(driver, PathConfiguration.TIMESTAMP, TestContext.CurrentContext.Test.Name);
                }
                TestStatusPass("[TEST] " + TestContext.CurrentContext.Test.Name + " has finished with status: PASSED",
                  (ConfigurationManager.AppSettings["screenshot"] == "ALWAYS" ? sspath : "")
                  );
            }
        }

        public void CloseReport()
        {
            extent.Flush();
        }

    }
}
