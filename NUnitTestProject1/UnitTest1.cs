using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Tests
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {


            IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);

            driver.Url = "https://beta-cricket-yahoo.sportz.io/";

            driver.Manage().Window.Maximize();

        }
    }
}