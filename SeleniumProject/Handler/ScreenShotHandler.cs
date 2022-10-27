using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using SeleniumProject.PageObject;


namespace SeleniumProject.Handler;

public class ScreenShotHandler
{
    // Method to obtain the directory location where we're going to save the image
    private static string DirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

    // Method to take screenschot with Selenium
    // It returns the image path taken
    public static string TakeScreenShot(IWebDriver driver)
    {
        long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

        string imagePath = DirectoryPath + "//img." + milliseconds + ".png";
        Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
        image.SaveAsFile(imagePath, ScreenshotImageFormat.Png);

        return imagePath;
    }
}

