using BingFrame;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BingSpcFlw.Steps
{
    [Binding]
    public class BingSearchSteps
    {
        [Given(@"I have navigated to (.*) page")]
        public void GivenIHaveNavigatedToBingWebsite(string page)
        {
            Names.Pages[page].Value.NavigateTo(Names.UrlBing);
        }

        [Given(@"I have navigated to page (.*) on the element (.*) and entered")]
        public void GivenIHaveEnteredStarWarsEpisodeViAsSearchKeyword(string page, string elementPage, Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Names.Pages[page].Value.FindElement(Names.Pages[page].Value.Elements[elementPage]).SendKeys((String)data.SearchString);
        }

        [When(@"I click on the search (.*) on the page (.*)")]
        public void WhenIPressTheSearchButton(string elementPage, string page)
        {
            Names.Pages[page].Value.FindElement(Names.Pages[page].Value.Elements[elementPage]).SendKeys(Keys.Enter);
        }

        [Then(@"I should be navigate to (.*) page and count (.*) elements (.*)")]
        public void ThenIShouldBeNavigateToSearchResultsPage(string page, int result, string elementPage)
        {
            Assert.AreEqual(result, Names.Pages[page].Value.FindElements(Names.Pages[page].Value.Elements[elementPage]).Count);
        }
    }
}