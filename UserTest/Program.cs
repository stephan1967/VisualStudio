using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.nu.nl");
            driver.Quit();

        }
    }
}
