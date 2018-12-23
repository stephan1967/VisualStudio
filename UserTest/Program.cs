using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using OpenQA.Selenium.Support.UI;

namespace UserTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.nu.nl");

            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            string saveLocation = @"C:\test\SearchInput.png"; 
            screenshot.SaveAsFile(saveLocation);

            driver.Quit();

        }
    }
}
