using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.PageObject;

namespace TestCases;

[TestFixture]
public class AddEmployeeTest
{

    protected IWebDriver Driver;

    // PageObject for the employee form
    private EmployeePage employeePage;

    [SetUp]
    public void BeforeTest()
    {
        Driver = new ChromeDriver();
        Driver.Navigate().GoToUrl("https://www.testfaceclub.com/ejercicios/");

        LoginPage loginPage = new LoginPage(Driver);
        employeePage = loginPage.LogInAs("admin", "123");
    }

    [Test]
    public void SuccesfulAddEmployeeTest()
    {
        employeePage.AddEmployee("jorge", "jorge@hotmail.com", "Av. Siempreviva 123", "123456789");
        Assert.IsTrue(employeePage.isSuccessAlertPresent());
    }

    [TearDown]
    public void AfterTest()
    {
        if (Driver != null)
        {
            Driver.Quit();
        }
    }
}

