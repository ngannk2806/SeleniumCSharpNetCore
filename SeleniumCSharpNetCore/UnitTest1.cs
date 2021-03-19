using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(@"C:\WebDriver");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://tiki.vn");
            IWebElement SearchTextBox = Driver.FindElement(By.XPath("//input[@data-view-id='main_search_form_input']"));
            SearchTextBox.SendKeys("Cometics");
            SearchTextBox.SendKeys(Keys.Enter);

            Boolean Present;
            try
            {
                Driver.FindElement(By.Id("normal-slidedown"));
                Present = true;
            } catch (NoSuchElementException)
            {
                Present = false;
                Console.WriteLine("Not existed 'asking about recieved notification popup'");
            }
            Assert.Pass();
        }
    }
}