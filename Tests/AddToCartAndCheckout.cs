using System;
using CornerStoneNUnit.Core;
using CornerStoneNUnit.JsonData;
using CornerStoneNUnit.PageObjects;
using CornerStoneNUnit.Utilities;

namespace CornerStoneNUnit.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]

    public class AddToCartAndCheckout:BaseClass
    {
        
        [Test]
        public void AddToCart()
        {
            AuthClass Auth = new AuthClass(driver);
            Auth.PerformLogin(data.CartUser.Email,data.CartUser.Password);
            AddToCartPage addToCart = new AddToCartPage(driver);
            addToCart.AddToCart();
            CheckOutPage checkOutPage = new CheckOutPage(driver);
            checkOutPage.Checkout();

            foreach (var accountDetails in data.PaymentDetails)
            {
                checkOutPage.Payment(
                    accountDetails.CardNumber,
                    accountDetails.ExpiryDate,
                    accountDetails.Name
                );
                bool OrderSuccessfull = checkOutPage.Orderconfirmed();
                if (OrderSuccessfull)
                {
                    Assert.True(checkOutPage.Orderconfirmed());
                }
                else
                {
                    Assert.False(checkOutPage.Orderconfirmed());

                }
            }

        }
    }
}
