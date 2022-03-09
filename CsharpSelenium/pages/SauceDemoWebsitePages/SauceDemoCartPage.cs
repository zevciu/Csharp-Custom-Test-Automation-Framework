using CsharpSelenium.utilities;
using OpenQA.Selenium;
using static CsharpSelenium.tests.BaseTest;

namespace CsharpSelenium.pages.SauceDemoWebsitePages
{
    public class SauceDemoCartPage : BasePage
    {
        private IWebElement goToInventoryPageButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/button[1]"));
        private IWebElement goToCheckoutStepOnePageButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/button[2]"));

        public SauceDemoCartPage(ReportHelper reportHelper) : base(reportHelper)
        {
        }

        public void GoToInventoryPage()
        {
            ClickElement(goToInventoryPageButton, "goToInventoryPageButton");
        }

        public void GoToCheckoutStepOnePage()
        {
            ClickElement(goToCheckoutStepOnePageButton, "goToCheckoutStepOnePageButton");
        }

    }
}
