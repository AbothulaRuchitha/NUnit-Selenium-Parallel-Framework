using System;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace CornerStoneNUnit.Utilities
{
    public class Reports
    {
        public static ExtentReports Extent;
        private static ThreadLocal<ExtentTest> Test= new ThreadLocal<ExtentTest>();
        public static void InitReports()
        {
            string projectRoot = AppDomain.CurrentDomain.BaseDirectory;
            string reportsFolder = Path.Combine(projectRoot, "Reports");

            if (!Directory.Exists(reportsFolder))
            {
                Directory.CreateDirectory(reportsFolder);
            }

            string filePath = Path.Combine(reportsFolder, "TestReport.html");
            var htmlReport = new ExtentSparkReporter(filePath);
            Extent = new ExtentReports();
            Extent.AttachReporter(htmlReport);
        }

        public static void CreateTest(string TestName)
        {
            Test.Value= Extent.CreateTest(TestName);
        }
        public static void LogPass(string Message)
        {
            Test.Value.Pass(Message);
        }
        public static void LogFail(string Message)
        {
            Test.Value.Fail(Message);
        }
        public static void Flush()
        {
            Extent.Flush();
        }
    }
}
