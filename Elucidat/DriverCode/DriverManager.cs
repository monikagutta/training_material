using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elucidat.StepDefinition
{
    class DriverManager
    {
        public static IWebDriver driver = null;
        public static void LaunchBrowser()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://learning.elucidat.com/course/602f99d64d0ac-602f9cb9b350d");
            driver.Manage().Window.Maximize();

        }

        public static void CloseBrowser()
        {
            //driver.Close();
            //driver.Quit();
        }
    }
}
