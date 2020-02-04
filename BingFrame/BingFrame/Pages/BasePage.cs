using BingFrame;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BingFrame
{
    [Binding]
    public class BasePage : IDisposable
    {
        IWebDriver driver;
        string type;
        string locale;

        public virtual Dictionary<string, By> Elements { get; set; }

        public string Locale { get { return locale; } }

        public BasePage(string url) : this()
        {
            NavigateTo(url);
        }

        public BasePage()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(this.GetType().Assembly.Location);
            AppSettingsSection configAppSettings = (AppSettingsSection)config.GetSection(Names.SectionAppSettings);
            type = configAppSettings.Settings[Names.Browser].Value; 
            locale = configAppSettings.Settings[Names.Locale].Value;
            SetDriver();
        }

        public void SetDriver()
        {
            string argumentLanguage = string.Format("--lang={0}", locale);
            switch (type)
            {
                case Names.FireFox:
                    OpenQA.Selenium.Firefox.FirefoxOptions firefoxOptions = new OpenQA.Selenium.Firefox.FirefoxOptions();
                    firefoxOptions.AddArguments(argumentLanguage);
                    driver = new OpenQA.Selenium.Firefox.FirefoxDriver(firefoxOptions);
                    break;
                case Names.Chrome:
                    OpenQA.Selenium.Chrome.ChromeOptions chromeOptions = new OpenQA.Selenium.Chrome.ChromeOptions();
                    chromeOptions.AddArguments(argumentLanguage);
                    driver = new OpenQA.Selenium.Chrome.ChromeDriver(chromeOptions);
                    break;
                default:
                    break;
            }
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string Title 
        {
            get
            {
                return driver.Title;
            }
        }

        public void Close()
        {
            driver.Close();
        }

        public void Maximize()
        {
            driver.Manage().Window.Maximize();
        }

        public IWebElement FindElementByText(By locator, string elementText)
        {
            var elements = FindElements(locator);
            return elements.FirstOrDefault(y => elements.Any(x => x.Text.ToUpperInvariant().Contains(elementText.ToUpperInvariant())));

        }

        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
                return driver.FindElements(locator);
            }
            catch (NoSuchElementException e1)
            {
                Console.WriteLine(GetType().Name + " could not find the element. " + locator + e1.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(GetType().Name + " encountered an error. " + e.Message);
                throw;
            }
        }

        public IWebElement FindElement(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }

        public void Type(string inputText, By locator)
        {
            FindElement(locator).SendKeys(inputText);
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }
        public void EnterQuerySearch(string url, string searchQueryText)
        {
            NavigateTo(url);
            FindElement(Elements["SearchInput"]).SendKeys(searchQueryText);
            FindElement(Elements["SearchInput"]).SendKeys(Keys.Enter);
        }
    }

}
