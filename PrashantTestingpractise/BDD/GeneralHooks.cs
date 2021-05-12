using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;

namespace PrashantTestingpractise.BDD
{
    [Binding]
    public sealed class GeneralHooks
    {
        private static ScenarioContext _scenariocontext;
        private static FeatureContext _featureContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extenthtmlreporter;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _extentReports = new ExtentReports();
            _extenthtmlreporter = new ExtentHtmlReporter(@"C:\Users\pkkbl\OneDrive\Desktop\ExtentReportPath\extentReport.html");
            _extentReports.AttachReporter(_extenthtmlreporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            if(null != featureContext)
            {
               _feature= _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title,
                    featureContext.FeatureInfo.Description);
            }
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            if(null != scenarioContext)
            {
                  _scenariocontext = scenarioContext;
               _scenario= _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title,
                    scenarioContext.ScenarioInfo.Description);
           }
        }
        [AfterStep]
        public static void AfterStep()
        {
            if (null!= _scenariocontext)
            {
                
                ScenarioBlock scenarioBlock = _scenariocontext.CurrentScenarioBlock;
                switch (scenarioBlock)
                {
                    case (ScenarioBlock.Given):
                        _scenario.CreateNode<Given>(_scenariocontext.StepContext.StepInfo.Text);
                        break;
                    case (ScenarioBlock.When):
                        _scenario.CreateNode<When>(_scenariocontext.StepContext.StepInfo.Text);
                        break;
                    case (ScenarioBlock.Then):
                        _scenario.CreateNode<Then>(_scenariocontext.StepContext.StepInfo.Text);
                        break;
                    default:
                        _scenario.CreateNode<And>(_scenariocontext.StepContext.StepInfo.Text);
                        break;
                        
                }
               
            }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            _extentReports.Flush();
        }


    }
}
