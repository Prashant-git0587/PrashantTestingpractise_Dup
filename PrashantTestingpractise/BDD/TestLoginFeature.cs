using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.IO;

namespace PrashantTestingpractise.BDD.StepDefinition
{    
    
    [Binding]
    public sealed class TestLoginFeature
    {
        private readonly ScenarioContext _ScenarioContext;

        public TestLoginFeature(ScenarioContext scenariocontext)
        {
            _ScenarioContext = scenariocontext;
        }

        [Given(@"scenario context dictionary is provided with value")]
        public void ThenScenarioContextDictionaryIsProvidedWithValue()
        {
            _ScenarioContext["numer1"] = 2;

        }

        [Given(@"scenario context is showing the scenario info")]
        public void ThenScenarioContextIsShowingTheScenarioInfo()
        {
            Console.WriteLine(_ScenarioContext.ScenarioInfo.Title);
        }

        private static IWebDriver driver;  
        [Given(@"Navigate to '(.*)'")]
        public void GivenNavigateTo(string str)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(str);
        }

        [Given(@"Home page is appearing")]
        public void GivenHomePageIsAppearing()
        {
            driver.Navigate().Refresh();
        }

        [When(@"Laon amount is '(.*)' Lakhs")]
        public void WhenLaonAmountIsLakhs(int p0)
        {
            Actions builder = new Actions(driver);
            IWebElement loanamountslider = driver.FindElement(By.CssSelector("#loanamountslider>span"));
            builder.DragAndDropToOffset(loanamountslider, 82, 0).Build().Perform();
            
        }

        [When(@"Interest rate is '(.*)'")]
        public void WhenInterestRateIs(string p0)
        {
            Actions builder = new Actions(driver);
            IWebElement loaninterestslider = driver.FindElement(By.CssSelector("#loaninterestslider>span"));
            builder.DragAndDropToOffset(loaninterestslider, 85, 0).Build().Perform();
        }

        [When(@"loan tenure is '(.*)' years")]
        public void WhenLoanTenureIsYears(int p0)
        {
            Actions builder = new Actions(driver);
            IWebElement loantermslider = driver.FindElement(By.CssSelector("#loantermslider>span"));
            builder.DragAndDropToOffset(loantermslider, -110, 0).Build().Perform();
        }

        [Then(@"calculated loan EMI is '(.*)'")]
        public void ThenCalculatedLoanEMIIs(Decimal p0)
        {
            Actions builder = new Actions(driver);
            IWebElement emiAmount = driver.FindElement(By.CssSelector("#emiamount>p>span"));
            string amount = emiAmount.Text;
            Assert.AreEqual("92,439", amount);
        }

        [Then(@"Just checking the example")]
        public void ThenJustCheckingTheExample()
        {
            Console.WriteLine();
        }

        const string notepadPath = @"C:\Users\pkkbl\OneDrive\Desktop\NotepadFile.txt";

        [Given(@"Notepad is open")]
        public void GivenNotepadIsOpen()
        {
            if(!File.Exists(notepadPath))
            {
                FileStream Fs = File.Create(@"C:\Users\pkkbl\OneDrive\Desktop\NotepadFile.txt");
            }
        }
              
        [When(@"Data is provided in the table")]
        public void WhenDataIsProvidedInTheTable(Table table)
        {
            using (StreamWriter sw = new StreamWriter(notepadPath))
            {
                int row = 0;
                foreach(TableRow tr in table.Rows)
                {
                    sw.WriteLine("Scenario No: " + tr["Scenario No"] +
                                        " Name: " + tr["Name"] +
                                        " Address: "+ tr["Address"]+
                                        " City: "+ tr["City"]+
                                        " Phone: "+ tr["Phone"]);
                }
                sw.Flush();
                sw.Close();
            }         

            
        }

        [Then(@"writes data in the notepad")]
        public void Justprint()
        {
            Console.WriteLine();
        }

        [When(@"the name of the person is ""(.*)""")]
        public void WhenTheNameOfThePersonIs(string name)
        {
            File.AppendAllText(notepadPath, "name: " + name);
        }

        [When(@"the address is ""(.*)""")]
        public void WhenTheAddressIs(string Address)
        {
            File.AppendAllText(notepadPath, " Address: " + Address);
        }

        [When(@"the city is ""(.*)""")]
        public void WhenTheCityIs(string city)
        {
            File.AppendAllText(notepadPath, " City: " + city);
        }

        [When(@"the phone is ""(.*)""")]
        public void WhenThePhoneIs(String Phone)
        {
            File.AppendAllText(notepadPath, " Phone: " + Phone + Environment.NewLine);
                  

        }



    }
}
