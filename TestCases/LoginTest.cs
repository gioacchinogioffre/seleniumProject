using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.PageObject;


namespace TestCases
{
    // NUnit notation to mark a class that contains test cases
    [TestFixture]
    public class LoginTest
    {

        // Selenium Driver
        protected IWebDriver Driver;

        // SetUp: NUnit notation to execute a method before each test.
        // Method to initiate Chrome and navigate to an url
        [SetUp]
        public void BeforeTest()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.testfaceclub.com/ejercicios/");
        }

        // Test: NUnit notation to mark a method as an automated test case
        // Method that implements Login test case. The expected result is that the user logs in.
        [Test]
        public void SuccesfulLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage = loginPage.LogInAs("admin", "123");

            Assert.IsTrue(employeePage.FormIsPresent());
        }

        // TearDown: NUnit notation to execute a method after each test.
        // Method to close the navigator.
        [TearDown]
        public void AfterTest()
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }

    }
}
