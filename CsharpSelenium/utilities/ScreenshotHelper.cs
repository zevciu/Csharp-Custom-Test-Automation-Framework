using System;
using OpenQA.Selenium;

namespace CsharpSelenium.utilities
{
    public class ScreenshotHelper
    {
        public void Take(IWebDriver driver, String timestamp, String filename)
        {      
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile(PathConfiguration.SCREENSHOTS_PATH + timestamp + "_" + filename + ".png", ScreenshotImageFormat.Png);
        }

        public string TakeAndGivePath(IWebDriver driver, String timestamp, String filename)
        {
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            String path = PathConfiguration.SCREENSHOTS_PATH + timestamp + "_" + filename + ".png";
            image.SaveAsFile(path, ScreenshotImageFormat.Png);
            return path;
        }
        public string TakeAsBase64String(IWebDriver driver)
        {
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            return image.AsBase64EncodedString;
        }


    }


    


}
