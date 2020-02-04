using BingFrame;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BingSpcFlw
{
    [Binding]
    public class ValidationUserNameSteps
    {
        [Given(@"I click (.*) on (.*)")]
        public void GivenIClickSignIn(string element, string page)
        {
            Names.Pages[page].Value.FindElement(Names.Pages[page].Value.Elements[element]).Click();
        }

        [When(@"I enter login details in (.*) and click (.*) on (.*) for (.*)")]
        public void WhenIEnterLoginDetailsFor(string elementInput, string elementNext, string page, string userType)
        {
            Names.Pages[page].Value.FindElement(Names.Pages[page].Value.Elements[elementInput]).SendKeys(userType);
            Names.Pages[page].Value.FindElement(Names.Pages[page].Value.Elements[elementNext]).Click();
        }

        [Then(@"I can see the validation error message on (.*) on (.*)")]
        public void ThenICanSeeTheValidationErrorMessage(string element, string page)
        {
            var invalidUserMessage = "That Microsoft account doesn't exist. Enter a different account";
            Assert.That(Names.Pages[page].Value.FindElement(Names.Pages[page].Value.Elements[element]).Text.Contains(invalidUserMessage));
        }
    }
}
