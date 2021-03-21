using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://www.lazada.vn/");
            CustomControl.CustomComboBox("search-box__input", "Comestic");

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
    }
}