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
    protected By NameInput = By.XPath("//*[@id=\"formEmployee\"]/div[2]/div[1]/input");
    protected By EmailInput = By.XPath("//*[@id=\"formEmployee\"]/div[2]/div[2]/input");
    protected By AddressTextArea = By.Id("address");
    protected By PhoneInput = By.Id("phone");
    protected By AddButton = By.Id("addButton");

    // Method to detect if the employee form is loaded. Returns true if the element is present; otherwise returns false.
    public bool FormIsPresent()
    {
        return WaitHandler.ElementIsPresent(Driver, Form);
    }

    // Method to add employee
    public void AddEmployee(string name, string email, string address, string phone)
    {
        Driver.FindElement(NameInput).SendKeys(name);
        Driver.FindElement(EmailInput).SendKeys(email);
        Driver.FindElement(AddressTextArea).SendKeys(address);
        Driver.FindElement(PhoneInput).SendKeys(phone);
        Driver.FindElement(AddButton).Click();
    }

    // Method to capture and accept an alert.
    // Returns true if an alert is detected and accepted; else returns false.
    public bool isSuccessAlertPresent()
    {
        try
        {
            Driver.SwitchTo().Alert().Accept();
            return true;
        }
        catch (NoAlertPresentException) { }

        return false;
    }

}

