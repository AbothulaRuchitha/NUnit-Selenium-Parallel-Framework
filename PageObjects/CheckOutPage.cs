using System;
using CornerStoneNUnit.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CornerStoneNUnit.PageObjects
{
    public class CheckOutPage:BasePage
    {
        private By CartButton = By.ClassName("navUser-item-cartLabel");
        private By ViewCartButton = By.XPath("//a[normalize-space(text())='View Cart']");
        private By CheckoutButton = By.XPath("//a[normalize-space(text())='Check out']");
        private By ContinueButton = By.Id("checkout-shipping-continue");
        private By Cardnumber = By.Id("ccNumber");
        private By Expiration = By.Id("ccExpiry");
        private By AccoutName = By.Id("ccName");
        private By PlaceOrderButton = By.Id("checkout-payment-continue");

        public CheckOutPage(IWebDriver driver):base(driver){}
        public void Checkout()
        {
            Click(CartButton);
            Click(ViewCartButton);
            Click(CheckoutButton);
            Click(ContinueButton);
        }
        public void Payment(String CardNumber,String ExpiryDate,String Name)
        {
            Type(Cardnumber, CardNumber);
            Type(Expiration, ExpiryDate);
            Type(AccoutName, Name);
            Click(PlaceOrderButton);

        }
        public bool Orderconfirmed()
        {
            return driver.Url.Contains(Json.GetData().OrderConfirmed);
        }
    }
}
