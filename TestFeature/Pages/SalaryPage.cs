using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFeature.Pages
{
    class SalaryPage : BasePage
    {

        public SalaryPage(IWebDriver webDriver, ExtentTest extentScenario) : base(webDriver, extentScenario)
        {
            this.webDriver = webDriver;
            this.extentScenario = extentScenario;
        }


        By heading = By.Id("heading");
        By name = By.Id("name");
        By hours = By.Id("hours");
        By salary = By.Id("salary");


        public string getHeading()
        { return fnGetText(heading, "heading"); }

        public string getName()
        { return fnGetText(name, "name"); }

        public string getHours()
        { return fnGetText(hours, "hours"); }

        public string getSalary()
        { return fnGetText(salary, "salary"); }



    }
}
