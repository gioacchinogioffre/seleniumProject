using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.PageObject;

namespace TestCases;

[TestFixture]
public abstract class BaseTest
{
    // Selenium Driver
    protected IWebDriver Driver;

    // SetUp: NUnit notation to execute a method before each test.
    // Method to initiate Chrome and navigate to an url
    [SetUp]
    public void BeforeBaseTest()
    {
        Driver = new ChromeDriver();
        Driver.Navigate().GoToUrl("https://www.testfaceclub.com/ejercicios/");
    }

    // TearDown: NUnit notation to execute a method after each test.
    // Method to close the navigator.
    [TearDown]
    public void AfterBaseTest()
    {
        if (Driver != null)
        {
            Driver.Quit();
        }
    }
}

