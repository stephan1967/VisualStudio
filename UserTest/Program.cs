using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            screenshot.SaveAsFile("SearchInput.png");     // Default path is C:\SW\UserTest\UserTest\bin\Debug\

            driver.Quit();

        }
    }
}
