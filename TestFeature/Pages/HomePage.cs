using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;

namespace TestFeature.Pages
{
    class HomePage : BasePage
    {

        public HomePage(IWebDriver webDriver, ExtentTest extentScenario) : base(webDriver, extentScenario)
        {
            this.webDriver = webDriver;
            this.extentScenario = extentScenario;
        }

        By heading = By.Id("heading");
        By name = By.Id("name");
        By rate = By.Id("rate");
        By mon = By.Id("mon");
        By tue = By.Id("tue");
        By wed = By.Id("wed");
        By thu = By.Id("thu");
        By fri = By.Id("fri");
        By sat = By.Id("sat");
        By sun = By.Id("sun");
        By submit = By.Id("submit");
        By reset = By.Id("reset");


        public string getHeading()
        { return fnGetText(heading, "heading"); }

        public void setName(string nameValue)
        { fnSetText(name, nameValue, "name"); }

        public void setRate(string rateValue)
        { fnSetText(rate, rateValue, "rate"); }

        public void setMon(string monValue)
        { fnSetText(mon, monValue, "mon"); }

        public void setTue(string tueValue)
        { fnSetText(tue, tueValue, "tue"); }

        public void setWed(string wedValue)
        { fnSetText(wed, wedValue, "wed"); }

        public void setThu(string thuValue)
        { fnSetText(thu, thuValue, "thu"); }

        public void setFri(string friValue)
        { fnSetText(fri, friValue, "fri"); }

        public void setSat(string satValue)
        { fnSetText(sat, satValue, "sat"); }

        public void setSun(string sunValue)
        { fnSetText(sun, sunValue, "sun"); }

        public void clickSubmit()
        { fnClickButton(submit, "submit"); }


        public bool checkRateValidation()
        { return fnIsAttribtuePresent(rate, "required"); }

        public bool checkNameValidation()
        { return fnIsAttribtuePresent(name, "required"); }




    }
}
