using System;
using CornerStoneNUnit.Core;
using CornerStoneNUnit.JsonData;
using CornerStoneNUnit.PageObjects;
using OpenQA.Selenium;

namespace CornerStoneNUnit.Utilities
{
    public class AuthClass
    {
        IWebDriver driver;
        public AuthClass(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void PerformLogin(String Email,String Password)
        {
            var Login = new LoginPage(driver);
            Login.SignInPage(Email,Password);

        }
    }
}
