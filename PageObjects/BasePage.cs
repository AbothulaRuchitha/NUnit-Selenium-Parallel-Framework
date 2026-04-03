using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace CornerStoneNUnit.PageObjects
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait=new WebDriverWait(driver,TimeSpan.FromSeconds(10));
        }
        protected IWebElement Find(By Locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(Locator));
        }
        protected void Click(By Locator)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", Find(Locator));
            wait.Until(ExpectedConditions.ElementToBeClickable(Locator)).Click();
        }
        protected void Type(By Locator, String Text)
        {
            var Element=Find(Locator);
            Element.SendKeys(Text);
        }


    }
}
