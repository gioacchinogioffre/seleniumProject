using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject.Handler;

// Class to handle explicit waits
public class WaitHandler
{
    // Method to wait for an element to be present on the webiste.Returns true if the element is found within 3 seconds; otherwise returns false.
    public static bool ElementIsPresent(IWebDriver driver, By locator)
    {
        try
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            wait.Until(drv => drv.FindElement(locator));
            return true;
        }
        catch
        {

        }

        return false;
    }
}

