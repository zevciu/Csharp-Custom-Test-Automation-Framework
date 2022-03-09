using System.Collections.Generic;
using CsharpSelenium.utilities;
using OpenQA.Selenium;
using static CsharpSelenium.tests.BaseTest;

namespace CsharpSelenium.pages.SauceDemoWebsitePages
{
    public class SauceDemoInventoryPage : BasePage
    {

        private IWebElement dropDownList = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div[2]/span/select"));

        private static IDictionary<string, string> shoppingItem = new Dictionary<string, string>(){
            {"Backpack", "add-to-cart-sauce-labs-backpack"},
            {"BikeLight", "add-to-cart-sauce-labs-bike-light"},
            {"BoltTshirt", "add-to-cart-sauce-labs-bolt-t-shirt"},
            {"FleeceJacket", "add-to-cart-sauce-labs-fleece-jacket"},
            {"Onesie", "add-to-cart-sauce-labs-onesie"},
            {"TshirtRed", "add-to-cart-test.allthethings()-t-shirt-(red)"}
         };

        public SauceDemoInventoryPage(ReportHelper reportHelper) : base(reportHelper)
        {
        }

        public bool IsDropDownListVisible()
        {
            return IsElementVisible(dropDownList, "dropDownList");
        }
        public void ExpandDropDownList()
        {
            ClickElement(dropDownList, "dropDownList");
        }

        public void AddItemToCart(string item)
        {
            ClickElement(driver.FindElement(By.XPath("//*[@id=\"" + shoppingItem[item] + "\"]")), item);
        }

    }
}
