using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class HomePage
    {
        private IWebDriver Driver;

        public HomePage(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        IWebElement btnLogin => Driver.FindElement(By.Id("loginLink"));
        IWebElement lnkLogOff => Driver.FindElement(By.LinkText("Log off"));

        public void clickLogin() => btnLogin.Click();
        public bool lnkLogOffExisted => lnkLogOff.Displayed;
    }
}
