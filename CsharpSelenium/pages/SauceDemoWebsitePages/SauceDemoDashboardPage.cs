using CsharpSelenium.utilities;
using OpenQA.Selenium;
using static CsharpSelenium.tests.BaseTest;

namespace CsharpSelenium.pages.SauceDemoWebsitePages
{
    public class SauceDemoDashboardPage : BasePage
    {
        private IWebElement goToCartPageButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[3]/a"));

        private IWebElement openBurgerMenuButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[1]/div/button"));
        private IWebElement logoutBurgerButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/nav/a[3]"));
        /*
        private IWebElement allItemsBurgerButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/nav/a[1]"));
        private IWebElement aboutBurgerButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/nav/a[2]"));        
        private IWebElement resetAppStateBurgerButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[1]/nav/a[4]"));
        private IWebElement exitBurgerMenuButton = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[1]/div/div[2]/div[2]/div/button"));
        */
        /*
        private IWebElement twitterButton = driver.FindElement(By.XPath("/html/body/div/div/footer/ul/li[1]/a"));
        private IWebElement facebookButton = driver.FindElement(By.XPath("/html/body/div/div/footer/ul/li[2]/a"));
        private IWebElement linkedinButton = driver.FindElement(By.XPath("/html/body/div/div/footer/ul/li[3]/a"));
        */

        public SauceDemoDashboardPage(ReportHelper reportHelper) : base(reportHelper)
        {
        }

        public void GoToCartPage()
        {
            ClickElement(goToCartPageButton, "goToCartPageButton");
        }

        public bool IsLogoutButtonVisible()
        {
            return IsElementVisible(logoutBurgerButton, "logoutBurgerButton");
        }

        public bool IsGoToCartPageButtonVisible()
        {
            return IsElementVisible(goToCartPageButton, "goToCartPageButton");
        }

        public void ExpandBurgerMenu()
        {
            ClickElement(openBurgerMenuButton, "openBurgerMenuButton");       
        }

        public void ClickLogoutBurgerButton()
        {
            ClickElement(logoutBurgerButton, "logoutBurgerButton");
        }
        /*
        public void ClickResetAppStateBurgerButton()
        {
            ClickElement(resetAppStateBurgerButton);
        }

        public void ClickAllItemsBurgerButton()
        {
            ClickElement(allItemsBurgerButton);
        }

        public void ClickAboutBurgerButton()
        {
            ClickElement(aboutBurgerButton);
        } 

        public void CloseBurgerMenu()
        {
            ClickElement(exitBurgerMenuButton);
        }
        */      
        /*
        public void GoToTwitter()
        {
            ClickElement(twitterButton);
        }

        public void GoToFacebook()
        {
            ClickElement(facebookButton);
        }

        public void GoToLinkedin()
        {
            ClickElement(linkedinButton);
        }
        */

    }
}
