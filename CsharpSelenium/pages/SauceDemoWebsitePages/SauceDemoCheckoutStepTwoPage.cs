using CsharpSelenium.utilities;
using OpenQA.Selenium;
using static CsharpSelenium.tests.BaseTest;

namespace CsharpSelenium.pages.SauceDemoWebsitePages
{
    public class SauceDemoCheckoutStepTwoPage : BasePage
    {
        private IWebElement goToCheckoutStepOnePageButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[8]/button[1]"));
        private IWebElement goToCheckoutCompletePageButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[8]/button[2]"));

        public SauceDemoCheckoutStepTwoPage(ReportHelper reportHelper) : base(reportHelper)
        {
        }

        public void GoToCheckoutStepOnePage()
        {
            ClickElement(goToCheckoutStepOnePageButton, "goToCheckoutStepOnePageButton");
        }

        public void GoToCheckoutCompletePage()
        {
            ClickElement(goToCheckoutCompletePageButton, "goToCheckoutCompletePageButton");
        }
    }
}
