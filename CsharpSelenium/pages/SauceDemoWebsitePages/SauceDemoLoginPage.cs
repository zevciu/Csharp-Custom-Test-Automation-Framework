using System;
using CsharpSelenium.utilities;
using OpenQA.Selenium;
using static CsharpSelenium.tests.BaseTest;

namespace CsharpSelenium.pages.SauceDemoWebsitePages
{
    public class SauceDemoLoginPage : BasePage
    {
        private IWebElement loginField = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[1]/input"));

        private IWebElement passwordField = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/div[2]/input"));

        private IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[1]/div[1]/div/form/input"));

        public SauceDemoLoginPage(ReportHelper reportHelper) : base(reportHelper)
        {
        }

        public void FillLoginForm(String login, String password)
        {
            FillElement(loginField, "loginField", login);
            FillElement(passwordField, "passwordField", password);
        }

        public void SubmitLoginForm()
        {
            ClickElement(loginButton, "loginButton");
        }

    }
}
