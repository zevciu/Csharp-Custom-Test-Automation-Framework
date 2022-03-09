using NUnit.Framework;

namespace CsharpSelenium.tests.SauceDemoWebsiteTests
{
    public class SauceDemoExecuteTests : BaseTest
    {
        [Test, Order(1)]
        public static void ExecuteLoginTest()
        {
            SauceDemoLoginTest.LoginTest();
        }

        [Test, Order(2)]
        public static void ExecuteAddToCartTest()
        {
            SauceDemoAddToCartTest.AddToCartTest();
        }

        [Test, Order(3)]
        public void PlaceOrderTest()
        {
            SauceDemoPlaceOrderTest.PlaceOrderTest();
        }

        [Test, Order(4)]
        public static void ExecuteLogoutTest()
        {
            SauceDemoLogoutTest.LogoutTest();
        }

    }
}
