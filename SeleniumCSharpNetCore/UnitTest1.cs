using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Configuration;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        private IWebDriver Driver;
        private CustomControl customControl;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(@"C:\WebDriver");
        }

        [Test]

        public void AccessToWebAppTest()
        {
            Driver.Navigate().GoToUrl("https://www.lazada.vn/");
            customControl.CustomCombobox("search-box__input--O34g", "Comestic" + Keys.Enter);

            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Console.WriteLine("Start Test Login");
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            homePage.clickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();

            Assert.That(homePage.lnkLogOffExisted, Is.True, "Log out button did not displayed");

            Console.WriteLine("Finish Test Login");
        }
    }
}