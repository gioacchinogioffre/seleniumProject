using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.PageObject;

namespace TestCases;

[TestFixture]
public class AddEmployeeTest : BaseTest
{


    // PageObject for the employee form
    private EmployeePage employeePage;

    [SetUp]
    public void BeforeTest()
    {

        LoginPage loginPage = new LoginPage(Driver);
        employeePage = loginPage.LogInAs("admin", "123");
    }

    [Test]
    public void SuccesfulAddEmployeeTest()
    {
        employeePage.AddEmployee("jorge", "jorge@hotmail.com", "Av. Siempreviva 123", "123456789");
        Assert.IsTrue(employeePage.isSuccessAlertPresent());
    }

}

