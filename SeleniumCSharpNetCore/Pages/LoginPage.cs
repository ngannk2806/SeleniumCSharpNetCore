using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LoginPage: DriverHelper
    {
        //// lazada
        //IWebElement txtUserName => Driver.FindElement(By.XPath("//div[@class='mod-login']//input[@type='text']"));
        //IWebElement txtPassword => Driver.FindElement(By.XPath("//div[@class='mod-login']//input[@type='password']"));
        //IWebElement btnLogin => Driver.FindElement(By.XPath("//div[@class='mod-login']//button[@type='submit']"));

        IWebElement txtUserName => Driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@type='submit']"));

        public void EnterUserNameAndPassword(String userName, String password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
