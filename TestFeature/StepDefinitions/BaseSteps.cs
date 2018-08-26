using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;


namespace TestFeature.StepDefinitions
{
    class BaseSteps
    {

        protected static IWebDriver driver;
        protected static String urlTest = "http://localhost:5000/";

        //*** Details for reporting ***//
        protected static ExtentReports extentReport = new ExtentReports();
        protected static ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter("extent"+ DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss") + ".html");
        protected static ExtentTest extentFeature; 
        protected static ExtentTest extentScenario; 
        protected static string strTestTitle = string.Empty;
       

    }
}
