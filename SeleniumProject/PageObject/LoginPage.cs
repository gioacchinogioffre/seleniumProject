using System;
using OpenQA.Selenium;


namespace SeleniumProject.PageObject;

public class LoginPage
{
    // Selenium Driver
    protected IWebDriver Driver;

    // Localizadores. We need to identify the ID'S of the things we want to test on the website.
    protected By UserInput = By.Id("user");
    protected By PasswordInput = By.Id("pass");
    protected By LogInButton = By.Id("loginButton");

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

}

