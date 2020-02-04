using BingFrame;
using System;
using TechTalk.SpecFlow;

namespace BingSpcFlw.Steps
{
    [Binding]
    public class SearchResultsOnRightSteps
    {
        [Given(@"I search for ""(.*)"" in (.*) on (.*)")]
        public void GivenISearchForInSearchInputOnBingAndEntered(string text, string element, string page)
        {
            Names.Pages[page].Value.FindElement(Names.Pages[page].Value.Elements[element]).SendKeys(text);
        }
    }
}
