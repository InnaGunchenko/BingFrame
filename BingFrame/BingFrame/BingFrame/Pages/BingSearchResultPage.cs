using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingFrame
{
    public class BingSearchResultPage: BasePage
    {
        public override Dictionary<string, By> Elements { get; set; } = new Dictionary<string, By>()
        {
            { "SearchResultsOnRight", By.XPath("//ol[@id='b_context']//div[@class='b_rrsr']//ul[@class='b_vList b_divsec']/li")},
            { "SearchResultsOnBottom", By.XPath("//div[@id='b_content']//div[@class='b_rs']//ul[@class='b_vList b_divsec']/li")},
            { "SearchResultsOnFirstPage", By.XPath("//div[@id='b_content']//ol[@id='b_results']/li[@class='b_algo']")},
            { "SerachResultSpecFlow", By.XPath("//div[@id='b_content']//ol[@id='b_results']/li")}
        };
    }
}
