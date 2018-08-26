using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace TestFeature.StepDefinitions
{[Binding]
    class CommonSteps:BaseSteps
    {

        public void fnVerifyValue(string expected, string actual, string message)
        {
            if (expected.Equals(actual))
                extentScenario.Pass("Verify " + message + " : " + expected);
            else
            {
                extentScenario.Fail("Fail " + message + " verification <br>Expected : " + expected + "<br> Actual : " + actual + "<br>Snapshot below: " + fnTakeScreenShots());
            }

        }


        public void fnVrifyTrue(bool expected, bool actual, string message)
        {
            if (expected.Equals(actual))
                extentScenario.Pass("Verify " + message + " : " + expected);
            else
            {
                extentScenario.Fail("Fail " + message + " verification <br>Expected : " + expected + "<br> Actual : " + actual + "<br>Snapshot below: " + fnTakeScreenShots());
            }

        }



        public void fnVerifyInputs(string inputString, string pageName)
        {
            string[] myDetails = inputString.Split(';');
            foreach (string details in myDetails)
            {
                string[] detail = details.Split('=');
                Type obT = Type.GetType(pageName);
                object[] paramArray = new object[] { driver, extentScenario };
                MethodInfo myMethod = obT.GetMethod("get" + detail[0]);
                var obStr = myMethod.Invoke(Activator.CreateInstance(obT, paramArray), null);
                fnVerifyValue(detail[1], obStr.ToString(), detail[0]);
            }
        }


        public String fnTakeScreenShots(String title="ImgError")
        {
            String screenShotPath = "";
            try
            {
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                string Runname = title + DateTime.Now.ToString("yyyyMMddHHmmsff");
                ss.SaveAsFile(Runname + ".png");
                screenShotPath = Runname + ".png";
            }
            catch
            {
                Console.WriteLine("fnTakeScreenShots fails");
            }
            return screenShotPath;
        }




    }
}
