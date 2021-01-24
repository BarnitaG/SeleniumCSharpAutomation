using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeSeleniumWIthCsharp
{
    public  class CustomControl:DriverHelper
    {
        public static void combobox(string controlName, string value)
        {
            IWebElement comboHolder = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboHolder.Clear();
            comboHolder.SendKeys(value);
            driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}
