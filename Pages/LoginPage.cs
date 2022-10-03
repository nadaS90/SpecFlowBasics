﻿using OpenQA.Selenium;
using SpecFlowBasics.Helpers;
namespace SpecFlowBasics.Pages;

public class LoginPage : PageBase
{
    public LoginPage(IWebDriver driver) : base(driver)
    {
    }

    #region MyRegion
    //Locators :
    public const String EmailID = "Email";
    public const String PasswordID = "Password";
    public const String LoginBtnID = "button.login-button";
    public const String ErrorMsgID = "div.message-error validation-summary-errors";
    #endregion

    IWebElement EmailTextBox => driver.FindElement(By.Id(EmailID));
    IWebElement PasswordTextField => driver.FindElement(By.Id(PasswordID));
    IWebElement LoginBtn => driver.FindElement(By.CssSelector(LoginBtnID));
    public IWebElement ErrorMsg => driver.FindElement(By.CssSelector(ErrorMsgID));


    public void UserEnterEmailAndPassword(String Email, String Password)
    {
        SendTxt(EmailTextBox, Email);
        SendTxt(PasswordTextField, Password);

    }

    public void UserLogIn()
    {
        ClickBtn(LoginBtn);
    }

}