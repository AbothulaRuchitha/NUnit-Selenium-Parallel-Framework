using System;
using CornerStoneNUnit.Core;
using CornerStoneNUnit.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CornerStoneNUnit.PageObjects
{
    public class AddToCartPage:BasePage
    {
        private By ShopAll = By.XPath("(//a[normalize-space(text())='Shop All'])[1]");
        private By SortOptions = By.Id("sort");
        private By Product1 = By.XPath("//a[normalize-space(text())='Ceramic Measuring Spoon Set']");
        private By AddToCartButton = By.Id("form-action-addToCart");
        private By CloseButton = By.XPath("(//button[@title='Close'])[3]");
        private By Product2 = By.XPath("//a[normalize-space(text())='Able Brewing System']");
        public AddToCartPage(IWebDriver driver):base(driver) {}
        public void AddToCart()
        {
            IList<By> Products= new List<By>() { Product1, Product2 };
            foreach (var Product in Products)
            {
                driver.FindElement(ShopAll).Click();
                SelectElement S = new SelectElement(driver.FindElement(SortOptions));
                S.SelectByValue(Json.GetData().SortOptions);
                Click(Product);
                Click(AddToCartButton);
                Click(CloseButton);
                
            }

        }
    }
}
