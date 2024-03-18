using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VueSchoolAutomationFramework.Utilities
{
    public class ExtentReport
    {
        public static ExtentReports _extentReports;
        public static ExtentTest _feature;
        public static ExtentTest _scenario;

        public static String dir = AppDomain.CurrentDomain.BaseDirectory;
        public static String testResultPath = dir.Replace("bin\\Debug\\net6.0", "TestResults");

        public static void ExtentReportInit()
        {
            var htmlReporter = new ExtentHtmlReporter(testResultPath);
            htmlReporter.Config.ReportName = "Automation Status Report";
            htmlReporter.Config.DocumentTitle = "Automation Status Report";
            htmlReporter.Config.Theme = Theme.Standard;
            htmlReporter.Start();

            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(htmlReporter);
            _extentReports.AddSystemInfo("Application", "&Wider");
            _extentReports.AddSystemInfo("Browser", "Chrome");
            _extentReports.AddSystemInfo("OS", "Windows");
        }

        public static void ExtentReportTearDown()
        {
            _extentReports.Flush();
        }

        //public string AddScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        //{
        //    ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
        //    Screenshot screenshot = takesScreenshot.GetScreenshot();
        //    string screenshotLocation = Path.Combine(testResultPath, scenarioContext.ScenarioInfo.Title + DateTime.UtcNow + ".png");
        //    screenshot.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
        //    return screenshotLocation;
        //}

        //public string AddScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        //{
        //    ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
        //    Screenshot screenshot = takesScreenshot.GetScreenshot();
        //    string timestamp = DateTime.Now.ToString("MMddyyyy_HHmmss"); // Get the local time and format it without invalid characters
        //    string sanitizedTitle = string.Join("_", scenarioContext.ScenarioInfo.Title.Split(Path.GetInvalidFileNameChars())); // Remove invalid characters from title
        //    string screenshotLocation = Path.Combine(testResultPath, sanitizedTitle + "_" + timestamp + ".png"); // Concatenate sanitized title and timestamp
        //    screenshot.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
        //    return screenshotLocation;
        //}

        public string AddScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string timestamp = DateTime.Now.ToString("MMddyyyy_HHmmss"); // Get the local time and format it without invalid characters
            string sanitizedTitle = string.Join("_", scenarioContext.ScenarioInfo.Title.Split(Path.GetInvalidFileNameChars())); // Remove invalid characters from title

            // Create a folder based on the current date if it doesn't exist
            string currentDateFolder = DateTime.Now.ToString("yyyyMMdd");
            string folderPath = Path.Combine(testResultPath, currentDateFolder);
            Directory.CreateDirectory(folderPath);

            // Construct the full screenshot file path within the folder
            string screenshotLocation = Path.Combine(folderPath, sanitizedTitle + "_" + timestamp + ".png");

            screenshot.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
            return screenshotLocation;
        }

    }
}
