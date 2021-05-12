using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;

namespace PrashantTestingpractise.BDD
{
    [Binding]
    public sealed class ScenarioContextTest
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public ScenarioContextTest(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
           
        }

        public string Title { get; set; }
        public string[] Tags { get; set; }

        [When(@"i execute my scenario")]
        public void ExecuteAnyScenario() { }

        [Then(@"The scenario info contains following informations")]
        public void ThenTheScenarioInfoContainsFollowingInformations(Table table)
        {
            //small DTO for info from the step
            var fromStep = table.CreateInstance<ScenarioContextTest>();
            fromStep.Tags = table.Rows[0]["value"].Split(',');

            //shorthand to the scenario info
            var si = _scenarioContext.ScenarioInfo;


            //Assertion
            si.Title.Equals(fromStep.Title);
            for(var i=0; i <= si.Tags.Length - 1; i++)
            {
                si.Tags[i].Equals(fromStep.Tags[i]);
            }

        }



    }
}
