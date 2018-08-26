using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFeature.Helpers
{
    class GetDriver
    {

        private static IWebDriver driver;
        const int waitTimeOut = 60;

        public static IWebDriver getWebDriver(String device = "chrome")
        {
            if (driver == null)
            {

                try
                {
                    switch (device)
                    {
                        case "chrome":
                            driver = new ChromeDriver();
                            break;
                        case "firefox":
                            driver = new FirefoxDriver();
                            break;
                        case "ie":
                            break;
                        default:
                            driver = new ChromeDriver();
                            break;
                    }
                    
                }
                catch (Exception ex)
                {
                    // throw 
                }
            }
            return driver;
        }



        public static void quitDrivers()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }

    }
}
