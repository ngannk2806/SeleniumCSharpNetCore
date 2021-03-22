using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore
{
    public class CustomControl: DriverHelper
    {
        public static void CustomComboBox(String controlName, String value)
        {
            IWebElement ComboBox = Driver.FindElement(By.XPath($"//input[@class='{controlName}']"));
            ComboBox.SendKeys($"{value}");
        }
    }
}
