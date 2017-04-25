using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumTesty
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://allegro.pl/");

            driver.FindElement(By.XPath(".//input[@id= 'main-search-text']")).SendKeys("Samsung Galaxy S8");
            driver.FindElement(By.XPath(".//input[@type='submit']")).Click();

            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath(".//*[@id='opbox-listing']/div/div/section[2]/section/article[1]/div/div/div[2]/h2/a")).Click(); 
            
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='add-to-cart']")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='cart-status-header']/a/span[2]/span")).Click();
            
        }
    }
}
