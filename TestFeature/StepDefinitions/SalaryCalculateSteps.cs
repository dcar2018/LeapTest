using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFeature.Helpers;
using TestFeature.Pages;

namespace TestFeature.StepDefinitions
{
    [Binding]
    class SalaryCalculateSteps:BaseSteps
    {
        EmployeeDetailsSteps employeeDetailsSteps = new EmployeeDetailsSteps();
        CommonSteps commonSteps = new CommonSteps();
        SalaryPage salaryPage = new SalaryPage(driver, extentScenario);


        [Given(@"I enter my time sheet (.*)")]
        public void GivenIEnterMyTimeSheet(string input)
        {
            employeeDetailsSteps.IOpenEmployeeDetailsApplication();
            employeeDetailsSteps.IEnterValuesToMyTimeSheet(input);
        }



        [Then(@"the application accepts the values successfully")]
        public void ApplicationAcceptsTimeSheetDetails()
        {
            commonSteps.fnVerifyValue(ApplicationValues.salaryPageHeading, salaryPage.getHeading(), "heading");
        }


        [Then(@"I can see my salary details and (.*)")]
        public void ThenICanSeeMySalaryDetailsAndVerify(string input)
        {
            commonSteps.fnVerifyInputs(input, "TestFeature.Pages.SalaryPage");
        }



    }
}
