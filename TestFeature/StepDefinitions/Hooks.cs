using AventStack.ExtentReports;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using TestFeature.Helpers;

namespace TestFeature.StepDefinitions
{
    [Binding]
    class Hooks : BaseSteps
    {

        [BeforeTestRun]
        public static void SetUpReport()
        {
            extentReport.AddSystemInfo("Application", "Salary application");
            extentReport.AttachReporter(htmlReporter);
            OperatingSystem os = Environment.OSVersion;
        }


        [BeforeFeature]
        public static void SetUpFeature()
        {
            extentFeature = extentReport.CreateTest(FeatureContext.Current.FeatureInfo.Title);
        }


        [BeforeScenario]
        public void SetUpTest()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("chrome"))
                driver = GetDriver.getWebDriver("chrome");
            else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("firefox"))
                driver = GetDriver.getWebDriver("firefox");

            driver.Manage().Window.Maximize();
            driver.Url = urlTest;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            extentScenario = extentFeature.CreateNode(ScenarioContext.Current.ScenarioInfo.Title); 
        }

        
        [BeforeStep]
        public static void beforeStep()
        {
            strTestTitle = ScenarioStepContext.Current.StepInfo.Text;
            extentScenario.Log(Status.Info, strTestTitle);
        }


        [AfterStep]
        public void AfterStep()
        {
        }


        [AfterScenario]
        public static void TearDown()
        {
            GetDriver.quitDrivers();
        }


        [AfterFeature]
        public static void FlushReport()
        {
            extentReport.Flush();
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
        }



    }
}
