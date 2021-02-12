using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace SizeControl
{
    class Program
    {
        static void Main()
        {
            Size size = new Size();
            size.Height = 600;
            size.Width = 600;
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://testing.todorvachev.com/");
            driver.Manage().Window.Size = size;
        }
    }
}
