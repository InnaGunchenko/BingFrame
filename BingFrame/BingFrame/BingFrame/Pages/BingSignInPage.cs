using OpenQA.Selenium;
using System.Collections.Generic;

namespace BingFrame
{
    public class BingSignInPage : BasePage
    {
        public override Dictionary<string, By> Elements { get; set; } = new Dictionary<string, By>()
        {
            { "Next", By.Id("idSIButton9")},
            { "ErrorMessage", By.Id("usernameError")},
            { "UserInput", By.Id("i0116")}
        };
    }
}
