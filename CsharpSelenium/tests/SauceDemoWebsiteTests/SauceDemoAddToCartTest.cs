using CsharpSelenium.pages.SauceDemoWebsitePages;

namespace CsharpSelenium.tests.SauceDemoWebsiteTests
{
    public class SauceDemoAddToCartTest : BaseTest
    {
        public static void AddToCartTest()
        {
            // Arrange
            // Settings derived from BaseTest.cs
            SauceDemoLoginTest.LoginTest();

            // Act
            SauceDemoInventoryPage sauceDemoInventoryPage = new SauceDemoInventoryPage(extent);
            sauceDemoInventoryPage.AddItemToCart("Backpack");
            sauceDemoInventoryPage.AddItemToCart("FleeceJacket");
            sauceDemoInventoryPage.AddItemToCart("Onesie");
            sauceDemoInventoryPage.AddItemToCart("TshirtRed");

            // Assert
            //To do: think of an appropriate way to make an assertion

        }

    }

}
