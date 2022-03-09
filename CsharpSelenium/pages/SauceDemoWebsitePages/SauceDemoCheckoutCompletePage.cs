using CsharpSelenium.utilities;
using OpenQA.Selenium;
using static CsharpSelenium.tests.BaseTest;

namespace CsharpSelenium.pages.SauceDemoWebsitePages
{
    public class SauceDemoCheckoutCompletePage : BasePage
    {
        private IWebElement backHomeButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/button"));

        public SauceDemoCheckoutCompletePage(ReportHelper reportHelper) : base(reportHelper)
        {
        }

        public bool IsBackHomeButtonVisible()
        {
            return IsElementVisible(backHomeButton, "backHomeButton");
        }
        

        public void ExitToMainPage()
        {
            ClickElement(backHomeButton, "backHomeButton");
        }
    }
}
