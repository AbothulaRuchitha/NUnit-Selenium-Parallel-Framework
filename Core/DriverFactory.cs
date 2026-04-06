using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace CornerStoneNUnit.Core
{
    public class DriverFactory
    {
        private static ThreadLocal<IWebDriver> driver=new ThreadLocal<IWebDriver>();
        public static IWebDriver InitDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--force-device-scale-factor=1");
            options.AddArgument("--high-dpi-support=1");
            options.AddArgument("--window-size=1920,1080");
            driver.Value = new ChromeDriver(options);
            return driver.Value;
        }
        
    }
}
