using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace TestFeature.Pages
{
    class BasePage
    {
        protected IWebDriver webDriver;
        protected ExtentTest extentScenario;
        protected static WebDriverWait webDriverWait;
        const int waitTimeOut = 60;



        public BasePage(IWebDriver webDriver, ExtentTest extentScenario)
        {
            this.webDriver = webDriver;
            this.extentScenario = extentScenario;
            if (webDriverWait == null)
            {
                webDriverWait = new WebDriverWait(this.webDriver, TimeSpan.FromSeconds(waitTimeOut));
            }
        }


        protected string fnGetText(By element, string elementName)
        {
            string text = string.Empty;
            try
            {
                text = webDriver.FindElement(element).Text;
            }
            catch (Exception e)
            {
                extentScenario.Fail("Fail to get text for " + elementName + "<br>Exception : " + e);
            }
            return text;
        }


        protected void fnSetText(By element, string value, string elementName)
        {
            try
            {
                webDriver.FindElement(element).Clear();
                webDriver.FindElement(element).SendKeys(value);
            }
            catch (Exception e)
            {
                extentScenario.Fail("Fail to set value \'" + value + "\' for " + elementName + "<br>Exception : " + e);
            }
        }


        protected void fnClickElement(By element, string elementName)
        {
            try
            {
                webDriver.FindElement(element).Click();

            }
            catch (Exception e)
            {
                extentScenario.Fail("Fail to click " + elementName + "<br>Exception : " + e);
            }
        }


        protected void fnClickButton(By element, string elementName)
        {
            try
            {
                webDriver.FindElement(element).Click();
            }
            catch (Exception e)
            {
                extentScenario.Fail("Fail to click " + elementName + "<br>Exception : " + e);
            }
        }


        protected bool fnIsAttribtuePresent(By by, String attribute)
        {
            bool result = false;
            try
            {
                string value = webDriver.FindElement(by).GetAttribute(attribute);
                if (value != null)
                {
                    result = true;
                }
            }
            catch (Exception e)
            {
                extentScenario.Fail("Fail to get attribute " + attribute + "<br>Exception : " + e);
            }
            return result;
        }

    }
}
