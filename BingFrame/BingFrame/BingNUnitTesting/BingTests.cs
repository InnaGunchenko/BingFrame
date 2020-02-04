using BingFrame;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BingNUnitTesting
{
    [TestFixture]
    public class BingTests
    {
        BingPage bingPage;
        int indexLocal;

        [OneTimeSetUp]
        public void BeforeTestSuit()
        {
            switch (Names.Pages["Bing"].Value.Locale)
            {
                case Names.US:
                    indexLocal = 0;
                    break;
                case Names.UA:
                    indexLocal = 1;
                    break;
                default:
                    break;
            }
        }

        [OneTimeTearDown]
        public void AfterTestSuit()
        {
            Names.Pages["Bing"].Value.Close();
        }

        [SetUp]
        public void SetUp()
        {

        }
        
        #region Displayed Test
        
        [Test]
        public void Bing_Images_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["Images"]).Displayed, string.Format("Element Images is not displayed"));
        }

        [Test]
        public void Bing_DotsMenuContainer_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["DotsMenuContainer"]).Displayed, string.Format("Element DotsMenuContainer is not displayed"));
        }
        
        [Test]
        public void Bing_SignIn_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["SignIn"]).Displayed, string.Format("Element SignIn is not displayed"));
        }

        [Test]
        public void Bing_Settings_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["Settings"]).Displayed, string.Format("Element Settings is not displayed"));
        }

        [Test]
        public void Bing_SearchInput_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["SearchInput"]).Displayed, string.Format("Element SearchInput is not displayed"));
        }
        
        [Test]
        public void Bing_SearchUsingAnImg_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["SearchUsingAnImg"]).Displayed, string.Format("Element SearchUsingAnImg is not displayed"));
        }

        [Test]
        public void Bing_SearchTheWeb_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["SearchTheWeb"]).Displayed, string.Format("Element SearchTheWeb is not displayed"));
        }

        [Test]
        public void Bing_HeadlineIcon_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["HeadlineIcon"]).Displayed, string.Format("Element HeadlineIcon is not displayed"));
        }

        [Test]
        public void Bing_Info_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["Info"]).Displayed, string.Format("Element Info is not displayed"));
        }

        [Test]
        public void Bing_LeftNav_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["LeftNav"]).Displayed, string.Format("Element LeftNav is not displayed"));
        }

        [Test]
        public void Bing_RightNav_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["RightNav"]).Displayed, string.Format("Element RightNav is not displayed"));
        }

        [Test]
        public void Bing_PrivacyAndCookiesLink_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["PrivacyAndCookiesLink"]).Displayed, string.Format("Element PrivacyAndCookiesLink is not displayed"));
        }

        [Test]
        public void Bing_LegalLink_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["LegalLink"]).Displayed, string.Format("Element LegalLink is not displayed"));
        }

        [Test]
        public void Bing_AdvertiseLink_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["AdvertiseLink"]).Displayed, string.Format("Element AdvertiseLink is not displayed"));
        }

        [Test]
        public void Bing_AboutOurAdsLink_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["AboutOurAdsLink"]).Displayed, string.Format("Element AboutOurAdsLink is not displayed"));
        }

        [Test]
        public void Bing_HelpLink_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["AboutOurAdsLink"]).Displayed, string.Format("Element AboutOurAdsLink is not displayed"));
        }
        
        [Test]
        public void Bing_FeedbackLink_Displayed_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["FeedbackLink"]).Displayed, string.Format("Element FeedbackLink is not displayed"));
        }

        #endregion

        #region Text Correct Test

        [Test]
        public void Bing_Images_TextCorrect_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["Images"]).Text, Is.EqualTo(Names.Images[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Images[indexLocal]));
        }

        [Test]
        public void Bing_SignIn_TextCorrect_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["SignIn"]).Text, Is.EqualTo(Names.SignIn[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.SignIn[indexLocal]));
        }

        [Test]
        public void Bing_Info_TextCorrect_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["Info"]).Text, Is.EqualTo(Names.Info[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Info[indexLocal]));
        }

        [Test]
        public void Bing_PrivacyAndCookies_TextCorrect_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["PrivacyAndCookies"]).Text, Is.EqualTo(Names.PrivacyAndCookies[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.PrivacyAndCookies[indexLocal]));
        }
        
        [Test]
        public void Bing_Legal_TextCorrect_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["LegalLink"]).Text, Is.EqualTo(Names.Legal[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Legal[indexLocal]));
        }

        [Test]
        public void Bing_Advertise_TextCorrect_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["AdvertiseLink"]).Text, Is.EqualTo(Names.Advertise[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Advertise[indexLocal]));
        }

        [Test]
        public void Bing_AboutOurAds_TextCorrect_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["AboutOurAdsLink"]).Text, Is.EqualTo(Names.AboutOurAds[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.AboutOurAds[indexLocal]));
        }

        [Test]
        public void Bing_HelpLink_TextCorrect_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["HelpLink"]).Text, Is.EqualTo(Names.Help[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Advertise[indexLocal]));
        }

        [Test]
        public void Bing_Feedback_TextCorrect_Test()
        {
            Assert.That(Names.Pages["Bing"].Value.FindElement(Names.Pages["Bing"].Value.Elements["FeedbackLink"]).Text, Is.EqualTo(Names.Feedback[indexLocal]), string.Format("Text {0} of the element is incorrectt", Names.Advertise[indexLocal]));
        }

        #endregion

        #region Сheck search result bottom and right

        [Test]
        public void Check_SearchResultsOnRight_CountElements_Test()
        {
            Names.Pages["Bing"].Value.EnterQuerySearch(Names.UrlBing, Names.SearchQueryText);
            Assert.AreEqual(Names.Eight, Names.Pages["Bing"].Value.FindElements(Names.Pages["Bing"].Value.Elements["SearchResultsOnRight"]).Count);
        }

        [Test]
        public void Check_SearchResultsOnBottom_CountElements_Test()
        {
            Names.Pages["Bing"].Value.EnterQuerySearch(Names.UrlBing, Names.SearchQueryText);
            Assert.AreEqual(Names.Eight, Names.Pages["Bing"].Value.FindElements(Names.Pages["Bing"].Value.Elements["SearchResultsOnBottom"]).Count);
        }

        #endregion

        #region Check search results on first page

        [Test]
        public void Check_SearchResultsOnFirstPage_CountElements_Test()
        {
            Names.Pages["Bing"].Value.EnterQuerySearch(Names.UrlBing, Names.SearchQueryText);
            Assert.AreEqual(Names.Ten, Names.Pages["Bing"].Value.FindElements(Names.Pages["Bing"].Value.Elements["SearchResultsOnFirstPage"]).Count);
        }
        
        #endregion
    }
}
