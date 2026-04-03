using System;
using CornerStoneNUnit.Core;
using CornerStoneNUnit.JsonData;
using CornerStoneNUnit.PageObjects;

namespace CornerStoneNUnit.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class InValidLogin:BaseClass
    {
        [Test]
        public void InvalidLoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            foreach (var user in data.InvalidUsers)
            {
                loginPage.SignInPage(user.Email, user.Password);
                Assert.IsTrue(loginPage.InvalidLogin());
            }


        }
    }
}
