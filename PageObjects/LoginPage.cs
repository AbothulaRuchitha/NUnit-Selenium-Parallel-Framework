
using CornerStoneNUnit.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V135.Network;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CornerStoneNUnit.PageObjects
{
    public class LoginPage:BasePage
    {
        private By SignIn = By.XPath("(//a[@aria-label='Sign in'])[1]");
        private By EmailField = By.Id("login_email");
        private By PasswordField = By.Id("login_pass");
        private By SignInButton = By.XPath("//input[@value='Sign in']");
        private By OrderButton = By.XPath("//a[text()='Orders']");
        private By ErrorMessage = By.XPath("//span[@class='form-inlineMessage']");
        private By AccountButton = By.XPath("(//a[normalize-space(text())='Account'])[1]");

        public LoginPage(IWebDriver driver) : base(driver) { }
        
        public void SignInPage(String Email, String Password)
        {
            Click(SignIn);
            Type(EmailField,Email);
            Type(PasswordField,Password);
            Click(SignInButton);


        }
        public bool ValidLogin()
        {
            return driver.FindElement(AccountButton).Enabled;
        }
        public bool InvalidLogin()
        {
            return driver.FindElement(SignIn).Enabled;

        }

    }
}
