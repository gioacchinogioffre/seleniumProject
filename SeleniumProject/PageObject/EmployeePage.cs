using System;
using OpenQA.Selenium;
using SeleniumProject.Handler;

namespace SeleniumProject.PageObject;

public class EmployeePage
{
    // Selenium Driver
    protected IWebDriver Driver;

    // Contstructor. Throws an excepction if the page title is not correct.
    public EmployeePage(IWebDriver driver)
    {
        Driver = driver;

        if (!Driver.Title.Equals("AUT Form – TestFaceClub"))
            throw new Exception("This is not the Employee Page");
    }

    // Localizadores

    protected By Form = By.Id("formEmployee");

    // Method to detect if the employee form is loaded. Returns true if the element is present; otherwise returns false.
    public bool FormIsPresent()
    {
        return WaitHandler.ElementIsPresent(Driver, Form);
    }

}

