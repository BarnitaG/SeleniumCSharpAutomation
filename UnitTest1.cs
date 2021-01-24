
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PracticeSeleniumWIthCsharp
{
    public class Tests:DriverHelper
    {
        
        [SetUp]
        public void Setup()
        {

            Console.WriteLine("Instantiating driver");
            Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Users\barnita.gupta\Driver\chromedriver.exe");
            ChromeOptions options = new ChromeOptions
            {
                BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
            };


            driver = new ChromeDriver(options);
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Opening Test URL");
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            driver.FindElement(By.CssSelector("#ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            CustomControl.combobox("ContentPlaceHolder1_AllMealsCombo", "Almonds");

            Assert.Pass();
        }

       [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}