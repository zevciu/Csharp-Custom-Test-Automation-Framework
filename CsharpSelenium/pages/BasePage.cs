using System;
using System.Threading;
using CsharpSelenium.utilities;
using OpenQA.Selenium;

namespace CsharpSelenium.pages
{
    public abstract class BasePage
    {

        protected ReportHelper extentReportHelper;
        public BasePage(ReportHelper reportHelper)
        {
            extentReportHelper = reportHelper;
        }
        
        protected void FillElement(IWebElement element, String elementName, String value)
        {
            element.Clear();
            if (element.Text.Equals(string.Empty)) {extentReportHelper.StepStatusPass("Cleared " + elementName + " content.");}
            else {extentReportHelper.StepStatusWarning(elementName + " content is not cleared. " + elementName + " value is: " + element.Text);}
            element.SendKeys(value);
            extentReportHelper.StepStatusPass("Sent keys: " + "\"" + value + "\"" + " to " + elementName);
        }

        protected void ClickElement(IWebElement element, String elementName)
        {
            if (IsElementVisible(element) == false) { 
                extentReportHelper.StepStatusWarning(elementName + " is not visible on the page. Initializing Wait-Time procedure of value: 1000 ms"); 
                Thread.Sleep(1000); 
                IsElementVisible(element, elementName); 
            }
            element.Click();         
            extentReportHelper.StepStatusPass("Clicked on the " + elementName);
        }

        protected bool IsElementVisible(IWebElement element, String elementName)
        {
            if (element.Displayed & element.Enabled == true) {extentReportHelper.StepStatusPass(elementName + " is visible on the page.");}
            else {extentReportHelper.StepStatusWarning(elementName + " is not visible on the page.");}
            return element.Displayed & element.Enabled;
        }

        protected bool IsElementVisible(IWebElement element)
        {
            return element.Displayed & element.Enabled;
        }

    }
}
