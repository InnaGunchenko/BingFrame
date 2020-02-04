using BingFrame;
using NUnit.Framework;
using System.Linq;
using TechTalk.SpecFlow;

namespace BingSpcFlw.Steps
{
    [Binding]
    public class TextOfElementSteps
    {
        [Then(@"I search element (.*) on (.*) and check the text of the element")]
        public void ThenIShouldCheckTheTextOfTheElement(string element, string page, Table table)
        {
            int i = 0;
            foreach (var item in Names.Pages[page].Value.FindElements(Names.Pages[page].Value.Elements[element]))
            {
                Assert.That(item.Text, Is.EqualTo(table.Rows[i].Values.ToArray()[0]), string.Format("Text {0} of the element is incorrectt", table.Rows[i].Values.ToArray()[0]));
                i++;
            }
        }
    }
}
