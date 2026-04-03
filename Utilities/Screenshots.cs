using System;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;

namespace CornerStoneNUnit.Utilities
{
    public class Screenshots
    {
        public static void CaptureScreeshot(IWebDriver driver)
        {
            var Res = TestContext.CurrentContext.Result;
            if (Res.Outcome.Status == TestStatus.Passed)
            {
                try
                {
                    string projectBin = AppDomain.CurrentDomain.BaseDirectory;
                    string folderPath = Path.Combine(projectBin, "Screenshots");

                    if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                    string timeStamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                    string fileName = $"{TestContext.CurrentContext.Test.Name}_{timeStamp}.png";
                    string filePath = Path.Combine(folderPath, fileName);
                    Screenshot S = ((ITakesScreenshot)driver).GetScreenshot();
                    S.SaveAsFile(filePath);

                    TestContext.WriteLine($"Screenshot saved at: {filePath}");
                }
                catch (Exception e)
                {
                    TestContext.WriteLine($"Failed to capture screenshot: {e.Message}");
                }
            }
        }

    }

}


