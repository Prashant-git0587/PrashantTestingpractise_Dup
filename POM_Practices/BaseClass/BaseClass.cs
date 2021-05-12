using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using POM_Practices.Settings;

namespace POM_Practices.BaseClass
{
    [TestFixture]
    class BaseClass
    {
        [OneTimeSetUp]
        public void IntializeClass()
        {
            ObjectInitialization.driver = new ChromeDriver();
            ObjectInitialization.driver.Navigate().GoToUrl("http://localhost:5001/");            
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            ObjectInitialization.driver.Close();
            ObjectInitialization.driver.Quit();

        }
    }
}
