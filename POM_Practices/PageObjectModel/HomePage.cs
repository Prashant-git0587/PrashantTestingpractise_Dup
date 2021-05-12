using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using POM_Practices.Settings;
using OpenQA.Selenium.Support.PageObjects;



namespace POM_Practices.PageObjectModel
{
    class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this); 
        }


        [FindsBy(How = How.XPath, Using = "//input[@id='quicksearch_top']")]
        IWebElement elementSearchBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='find_top']")]
        IWebElement Button;

        public void ClickOnButtons(string TexttoBePrinted)
        {
            elementSearchBox.SendKeys(TexttoBePrinted);
            Button.Click();
            
        }
           





    }
}
