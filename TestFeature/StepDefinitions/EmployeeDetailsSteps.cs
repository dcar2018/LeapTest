using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFeature.Helpers;
using TestFeature.Pages;

namespace TestFeature.StepDefinitions
{
    [Binding]
    class EmployeeDetailsSteps : BaseSteps
    {
        CommonSteps commonSteps = new CommonSteps();
        HomePage homePage = new HomePage(driver, extentScenario);
        SalaryPage salaryPage = new SalaryPage(driver, extentScenario);
      


        [Given(@"I open employee details application")]
        public void IOpenEmployeeDetailsApplication()
        {
            commonSteps.fnVerifyValue(ApplicationValues.homePageHeading, homePage.getHeading(), "heading");
        }



        [When(@"I enter values to my time sheet (.*)")]
        public void IEnterValuesToMyTimeSheet(string input)
        {
            string[] myDetails = input.Split(';');
            homePage.setName(myDetails[0]);
            homePage.setRate(myDetails[1]);
            homePage.setMon(myDetails[2]);
            homePage.setTue(myDetails[3]);
            homePage.setWed(myDetails[4]);
            homePage.setThu(myDetails[5]);
            homePage.setFri(myDetails[6]);
            homePage.setSat(myDetails[7]);
            homePage.setSun(myDetails[8]);
        }

        [When(@"I select submit button")]
        public void SelectSubmitButton()
        {
            homePage.clickSubmit();
        }



        [Then(@"the application validates my inputs (.*)")]
        public void ThenTheApplicationValidatesMyInputs(string field)
        {
            if (field.ToLower() == "rate")
                commonSteps.fnVrifyTrue(true, homePage.checkRateValidation(), "Rate field validation");
            else if (field.ToLower() == "name")
                commonSteps.fnVrifyTrue(true, homePage.checkNameValidation(), "Name field validation");
            Thread.Sleep(10000);
        }




    }
}
