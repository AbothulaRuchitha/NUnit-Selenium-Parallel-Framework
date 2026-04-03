

using System;
using System.Security.Cryptography.X509Certificates;
using CornerStoneNUnit.JsonData;
using CornerStoneNUnit.PageObjects;
using CornerStoneNUnit.Utilities;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace CornerStoneNUnit.Core
{
    [TestFixture]
    public class BaseClass
    {
        public IWebDriver driver;
        protected Data data;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Reports.InitReports();   

        }

        [SetUp]
        public void SetUp()
        {
            driver=DriverFactory.InitDriver();
            data = Json.GetData();
            driver.Navigate().GoToUrl(data.WebsiteUrl);
            Reports.CreateTest(TestContext.CurrentContext.Test.Name); 
        }


        [TearDown]
        public void TearDown()
        {
            Screenshots.CaptureScreeshot(driver);

            var Res = TestContext.CurrentContext.Result.Outcome.Status;

            if (Res == TestStatus.Passed)
            {
                Reports.LogPass("Test Passed");
            }
            else if (Res == TestStatus.Failed)
            {
                Reports.LogFail("Test Failed: " + TestContext.CurrentContext.Result.Message);
            }
            DriverFactory.QuitDriver();

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Reports.Flush();    
        }
    }
}
