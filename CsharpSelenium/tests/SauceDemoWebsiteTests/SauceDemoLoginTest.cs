using System.Configuration;
using CsharpSelenium.pages.SauceDemoWebsitePages;
using NUnit.Framework;

namespace CsharpSelenium.tests.SauceDemoWebsiteTests
{
    public class SauceDemoLoginTest : BaseTest
    {
        public static void LoginTest()
        {
            // Arrange
            // Settings derived from BaseTest.cs

            // Act
            SauceDemoLoginPage sauceDemoLoginPage = new SauceDemoLoginPage(extent);
            sauceDemoLoginPage.FillLoginForm(ConfigurationManager.AppSettings["login"], ConfigurationManager.AppSettings["password"]);
            sauceDemoLoginPage.SubmitLoginForm();

            // Assert
            Assert.AreNotEqual(driver.Url, ConfigurationManager.AppSettings["URL"]);
        }

    }
}
