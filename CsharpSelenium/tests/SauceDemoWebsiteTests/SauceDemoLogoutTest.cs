using System.Configuration;
using CsharpSelenium.pages.SauceDemoWebsitePages;
using NUnit.Framework;

namespace CsharpSelenium.tests.SauceDemoWebsiteTests
{
    public class SauceDemoLogoutTest : BaseTest
    {
        public static void LogoutTest()
        {
            // Arrange
            // Settings derived from BaseTest.cs
            SauceDemoLoginTest.LoginTest();

            // Act
            SauceDemoDashboardPage sauceDemoDashboardPage = new SauceDemoDashboardPage(extent);
            sauceDemoDashboardPage.ExpandBurgerMenu();
            sauceDemoDashboardPage.ClickLogoutBurgerButton();

            // Assert
            Assert.AreEqual(driver.Url, ConfigurationManager.AppSettings["URL"]);
        }


    }
}
