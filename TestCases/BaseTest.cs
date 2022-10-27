using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using SeleniumProject.PageObject;
using SeleniumProject.Handler;

namespace TestCases;

[TestFixture]
public abstract class BaseTest
{
    // Selenium Driver
    protected IWebDriver Driver;

    protected string url = ConfigurationManager.AppSettings["url"];

    // SetUp: NUnit notation to execute a method before each test.
    // Method to initiate Chrome and navigate to an url
    [SetUp]
    public void BeforeBaseTest()
    {
        Driver = new ChromeDriver();
        // CAMBIAR PARAMETRO POR VARIABLE URL
        Driver.Navigate().GoToUrl("https://www.testfaceclub.com/ejercicios/");
    }

    // TearDown: NUnit notation to execute a method after each test.
    // Method to close the navigator.
    [TearDown]
    public void AfterBaseTest()
    {
        var status = TestContext.CurrentContext.Result.Outcome.Status;

        if (status == TestStatus.Failed)
            ScreenShotHandler.TakeScreenShot(Driver);

        if (Driver != null)
        {
            Driver.Quit();
        }
    }
}

