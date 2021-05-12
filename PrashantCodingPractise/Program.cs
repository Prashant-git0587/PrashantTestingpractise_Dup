using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using java.awt;

namespace PrashantCodingPractise
{

    class MainMethod
    { 
 
        private static string URL1 = "https://www.udemy.com/";
        private static string URL2 = "http://localhost:5001/";
        private static string URL3 = "http://uitestpractice.com/Students/Switchto";
        private static IWebDriver driver = new ChromeDriver();

        [FindsBy(How = How.Id, Using = "prashant")]
        private IWebElement Element { get; set; }

        public void StartTheDriver()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(URL3);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120000);
            
        }
        public void tearDown()
        {
            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();
        }
        public static void Main()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);
            MainMethod m = new MainMethod();
            m.StartTheDriver();
            IReadOnlyCollection<IWebElement> iframeElements = driver.FindElements(By.TagName("iframe"));
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='iframe_a']")));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5000));
            IWebElement element = wait.Until(ExpectedConditions.ElementExists(By.XPath("//input([@id='name']")));
            element.SendKeys("Prashant");
            element.Clear();
            element.SendKeys("Nishant");
            
            
            




           











            Thread.Sleep(5000);
            m.tearDown();


           

        }


    }
}
