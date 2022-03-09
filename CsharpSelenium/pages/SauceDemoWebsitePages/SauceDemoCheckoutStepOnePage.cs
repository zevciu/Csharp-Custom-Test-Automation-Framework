using CsharpSelenium.utilities;
using OpenQA.Selenium;
using static CsharpSelenium.tests.BaseTest;

namespace CsharpSelenium.pages.SauceDemoWebsitePages
{
    public class SauceDemoCheckoutStepOnePage : BasePage
    {
        private IWebElement firstNameField = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[1]/input"));
        private IWebElement lastNameField = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[2]/input"));
        private IWebElement postalCodeField = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[1]/div[3]/input"));

        private IWebElement goToCartPageButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[2]/button"));
        private IWebElement goToCheckoutStepTwoPageButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/form/div[2]/input"));

        public SauceDemoCheckoutStepOnePage(ReportHelper reportHelper) : base(reportHelper)
        {
        }

        public void FillForm(string someFirstName, string someLastName, string somePostalCode)
        {
            FillElement(firstNameField, "firstNameField", someFirstName);
            FillElement(lastNameField, "lastNameField", someLastName);
            FillElement(postalCodeField, "postalCodeField", somePostalCode);
        }

        public void GoToCartPage()
        {
            ClickElement(goToCartPageButton, "goToCartPageButton");
        }

        public void GoToCheckoutStepTwoPage()
        {
            ClickElement(goToCheckoutStepTwoPageButton, "goToCheckoutStepTwoPageButton");
        }

    }
}
