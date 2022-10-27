using System;
using OpenQA.Selenium;


namespace SeleniumProject.PageObject;

public class LoginPage : BasePage
{

    // Localizadores. We need to identify the ID'S of the things we want to test on the website.
    protected By UserInput = By.Id("user");
    protected By PasswordInput = By.Id("pass");
    protected By LogInButton = By.Id("loginButton");

    // Contstructor. Throws an excepction if the page title is not correct.
    public LoginPage(IWebDriver driver)
    {
        Driver = driver;

        if (!Driver.Title.Equals("AUT Login – TestFaceClub"))
            throw new Exception("This is not the login page");
    }

    // Method to type username
    public void TypeUserName(string user)
    {
        Driver.FindElement(UserInput).SendKeys(user);
    }

    // Method to type password
    public void TypePassword(string password)
    {
        Driver.FindElement(PasswordInput).SendKeys(password);
    }

    // Method to click log in button
    public void ClickLogInButton()
    {
        Driver.FindElement(LogInButton).Click();
    }

    // Method to log in. It returns the Employee Page
    public EmployeePage LogInAs(string user, string password)
    {
        TypeUserName(user);
        TypePassword(password);
        ClickLogInButton();
        return new EmployeePage(Driver);
    }

}

