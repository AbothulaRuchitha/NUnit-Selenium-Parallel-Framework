using System;
using CornerStoneNUnit.Core;
using CornerStoneNUnit.PageObjects;
using CornerStoneNUnit.Utilities;

namespace CornerStoneNUnit.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class ValidLogin:BaseClass
    {
        [Test]
        public void ValidLoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            AuthClass Auth = new AuthClass(driver);
            Auth.PerformLogin(data.LoginUser.Email,data.LoginUser.Password);
            Assert.IsTrue(loginPage.ValidLogin());

        }
    }
}
