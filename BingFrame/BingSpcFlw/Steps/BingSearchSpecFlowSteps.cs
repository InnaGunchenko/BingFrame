using BingFrame;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace BingSpcFlw
{
    [Binding]
    public class BingSearchSpecFlowSteps
    {
        [When(@"I search for ""(.*)"" in (.*) on (.*)")]
        public void WhenISearchForSpecFlowInSearchInput(string searchText, string element, string page)
        {
            Names.Pages[page].Value.FindElement(Names.Pages[page].Value.Elements[element]).SendKeys(searchText);
            Names.Pages[page].Value.FindElement(Names.Pages[page].Value.Elements[element]).SendKeys(Keys.Enter);
        }
        
        [When(@"select ""(.*)"" from (.*) on (.*)")]
        public void WhenSelectInTheSearchResults(string expResult, string element, string page)
        {
            Names.Pages[page].Value.FindElements(Names.Pages[page].Value.Elements[element]).ToList().FirstOrDefault(x => x.Text.Contains(expResult)).Click();
        }
        
        [Then(@"I am presented with the ""(.*)"" homepage (.*)")]
        public void ThenIAmPresentedWithTheHomepage(string title, string page)
        {
            Assert.That(Names.Pages[page].Value.Title.Contains(title));
        }
    }
}
