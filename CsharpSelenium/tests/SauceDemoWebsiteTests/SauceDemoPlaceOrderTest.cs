using CsharpSelenium.pages.SauceDemoWebsitePages;
using NUnit.Framework;

namespace CsharpSelenium.tests.SauceDemoWebsiteTests
{
    public class SauceDemoPlaceOrderTest : BaseTest
    {
        public static void PlaceOrderTest()
        {
        // Arrange
        // Settings derived from BaseTest.cs
        SauceDemoAddToCartTest.AddToCartTest();

        // Act
        SauceDemoDashboardPage sauceDemoDashboardPage = new SauceDemoDashboardPage(extent);
        sauceDemoDashboardPage.GoToCartPage();

        SauceDemoCartPage sauceDemoCartPage = new SauceDemoCartPage(extent);
        sauceDemoCartPage.GoToCheckoutStepOnePage();

        SauceDemoCheckoutStepOnePage sauceDemoCheckoutStepOnePage = new SauceDemoCheckoutStepOnePage(extent);
        sauceDemoCheckoutStepOnePage.FillForm(generate.RandomString(5, "alphabetic"), generate.RandomString(8, "alphabetic"), generate.RandomString(10, "alphabetic"));
        sauceDemoCheckoutStepOnePage.GoToCheckoutStepTwoPage();

        SauceDemoCheckoutStepTwoPage sauceDemoCheckoutStepTwoPage = new SauceDemoCheckoutStepTwoPage(extent);
        sauceDemoCheckoutStepTwoPage.GoToCheckoutCompletePage();

        // Assert
        SauceDemoCheckoutCompletePage sauceDemoCheckoutCompletePage = new SauceDemoCheckoutCompletePage(extent);
        Assert.True(sauceDemoCheckoutCompletePage.IsBackHomeButtonVisible());
        }

    }
}
