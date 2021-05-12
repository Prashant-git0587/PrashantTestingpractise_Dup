using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using PrashantTestingpractise.Settings;
using PrashantTestingpractise.Configuration;
using PrashantTestingpractise.CustomExceptions;

namespace PrashantTestingpractise.BaseClasses
{
    [TestFixture]
    public class BaseClass
    {
        private IWebDriver GetChromedriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
        [OneTimeSetUp]
        public void InitializeTest()
        {
            ObjectRepository.config = new ConfigReader();
            BrowserType browser = ObjectRepository.config.GetBrowserName();
            switch (browser)
            {
                case BrowserType.Chrome:
                    ObjectRepository.driver =  GetChromedriver();
                    break;
                    
                default:
                    throw new CustomException(browser.ToString() + " " + "browser is not found");
            }
        }
        [OneTimeTearDown]
        public  void TearDown()
        {
            
            ObjectRepository.driver.Close();
            ObjectRepository.driver.Quit();
        }
        
    }
}
