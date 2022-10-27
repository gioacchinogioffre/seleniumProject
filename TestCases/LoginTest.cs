using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumProject.PageObject;


namespace TestCases;

// NUnit notation to mark a class that contains test cases
[TestFixture]
public class LoginTest : BaseTest
{


    // Test: NUnit notation to mark a method as an automated test case
    // Method that implements Login test case. The expected result is that the user logs in.
    [Test]
    public void SuccesfulLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        EmployeePage employeePage = loginPage.LogInAs("admin", "123");

        Assert.IsTrue(employeePage.FormIsPresent());
    }


}
