using System;
using TechTalk.SpecFlow;

namespace ConsoleApp2.BDD
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have a console")]
        public void GivenIHaveAConsole()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have entered data to the console")]
        public void GivenIHaveEnteredDataToTheConsole()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I finish answering the question")]
        public void WhenIFinishAnsweringTheQuestion()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be saved in the database")]
        public void ThenTheResultShouldBeSavedInTheDatabase()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
