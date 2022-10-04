using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewEmployerPage
{
    public partial class MdlWndwAddNewEmployer
    {
        [AllureStep("EnterNameEmployerMdlWndwAddNewEmplr")]
        public MdlWndwAddNewEmployer EnterNameEmployerMdlWndwAddNewEmplr()
        {
            //InputGeneral.InputFunctionWithClear(FieldInputNameEmployerMdlWndwAddNewEmplrPg, Name.FirstName());

            InputGeneral.InputFunctionWithClear(FieldInputNameEmployerMdlWndwAddNewEmplrPg, TestDataEmployers.nameEmployerFrank);

            return this;
        }

        [AllureStep("ClickDropDownAddClinicianMdlWndwAddNewEmplrPg")]
        public MdlWndwAddNewEmployer ClickDropDownAddClinicianMdlWndwAddNewEmplrPg()
        {
            Button.Click(DropDownAddClinicianMdlWndwAddNewEmplrPg);

            return this;
        }

        [AllureStep("ClickFieldInputNameEmployerMdlWndwAddNewEmplrPg")]
        public MdlWndwAddNewEmployer ClickFieldInputNameEmployerMdlWndwAddNewEmplrPg()
        {
            Button.Click(FieldInputNameEmployerMdlWndwAddNewEmplrPg);

            return this;
        }

        [AllureStep("ClickButtonAddMdlWndwAddNewEmplrPg")]
        public MdlWndwAddNewEmployer ClickButtonAddMdlWndwAddNewEmplrPg()
        {
            Button.Click(ButtonAddMdlWndwAddNewEmplrPg);

            return this;
        }

        private static IWebElement _element;

        [AllureStep("SelectorForClinicianMdlWndwAddNewEmplr")]
        public static IList<IWebElement> SelectorForClinicianMdlWndwAddNewEmplr(string _locationClinician)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@role= 'listbox']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//mat-option[contains(@id, '{_locationClinician}')]"));
        }

        [AllureStep("SelectClinicianMdlWndwAddNewEmplr")]
        public MdlWndwAddNewEmployer SelectClinicianMdlWndwAddNewEmplr(int clinician, string locationClinician)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _clinician = SelectorForClinicianMdlWndwAddNewEmplr(locationClinician);

            _clinician[clinician].Click();

            return this;
        }
    }
}
