using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore
{
    public class CustomControl
    {
        private IWebElement Driver;

        public CustomControl(IWebElement Driver)
        {
            this.Driver = Driver;
        }
        public void CustomCombobox(string controlname, string value)
        {
            IWebElement combobox = Driver.FindElement(By.XPath($"//input[@class='{controlname}']"));
            combobox.SendKeys($"{value}");
        }
    }
}
