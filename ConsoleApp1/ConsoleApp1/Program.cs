using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //deschide browserul
            //navigheaza la linkul "https://www.google.ro/"

            IWebElement web_element = null;
            FirefoxOptions options = new FirefoxOptions();
            options.AcceptInsecureCertificates = true;
            IWebDriver driver = new FirefoxDriver(options);
            driver.Url = "https://www.google.ro/";
            
            driver.Manage().Window.Maximize();

            //identifica prin XPATH campul de cautare
            web_element = driver.FindElement(By.XPath("//*[@id='lst - ib']"));

            //introdu textul "selenium" in campul de cautare
            web_element.SendKeys("selenium");

            //identifica prin XPATH butonul "Google Search"
            web_element = driver.FindElement(By.XPath(".//input[@name='btnK']"));

            //click pe butonul "Google Search" 
            web_element.Click();
            Console.ReadLine();

            //click pe primul rezultat
            web_element = driver.FindElement(By.XPath(".//a[contains(text(),'Automation')]"));
            web_element.Click();


        }
    }
}
