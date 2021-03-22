using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;
using System;
using System.Configuration;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(@"C:\WebDriver");
        }

        [Test]

        public void AccessToWebAppTest()
        {
            Driver.Navigate().GoToUrl("https://www.lazada.vn/");
            CustomControl.CustomComboBox("search-box__input--O34g", "Comestic" + Keys.Enter);

              Boolean Present;
            try
            {
                Driver.FindElement(By.Id("normal-slidedown"));
                Present = true;
            }
            catch (NoSuchElementException)
            {
                Present = false;
                Console.WriteLine("Not existed 'asking about recieved notification popup'");
            }
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.clickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();

            Assert.That(homePage.lnkLogOffExisted, Is.True, "Log out button did not displayed");
        }
    }
}