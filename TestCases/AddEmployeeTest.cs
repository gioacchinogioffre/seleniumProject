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

    // NUnit notation to mark a method as an Automated Test Case with parameters.
    // In this case, the case is gonna be tested twice.
    [TestCase("jorge", "jorge@hotmail.com", "Av Siempreviva 123", "123455")]
    [TestCase("juan", "juan@hotmail.com", "Av Siempreviva 3291", "981923812")]
    public void SuccesfulAddEmployeeTest(string name, string email, string address, string phone)
    {
        employeePage.AddEmployee(name, email, address, phone);
        Assert.IsTrue(employeePage.isSuccessAlertPresent());
    }

}

