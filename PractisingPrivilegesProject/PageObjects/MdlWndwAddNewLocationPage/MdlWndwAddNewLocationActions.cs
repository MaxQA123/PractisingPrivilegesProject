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

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewLocationPage
{
    public partial class MdlWndwAddNewLocation
    {
        [AllureStep("EnterNameLocation")]
        public MdlWndwAddNewLocation EnterNameLocationMdlWndwAddNewLctn()
        {
            InputGeneral.InputFunctionWithClear(FieldInputNameLocationMdlWndwAddNewLctnPg, Address.City());

            return this;
        }

        [AllureStep("ClickDropDownAddClinicianMdlWndwAddNewLctnPg")]
        public MdlWndwAddNewLocation ClickDropDownAddClinicianMdlWndwAddNewLctnPg()
        {
            Button.Click(DropDownAddClinicianMdlWndwAddNewLctnPg);

            return this;
        }

        [AllureStep("ClickFieldInputNameLocationMdlWndwAddNewLctnPg")]
        public MdlWndwAddNewLocation ClickFieldInputNameLocationMdlWndwAddNewLctnPg()
        {
            Button.Click(FieldInputNameLocationMdlWndwAddNewLctnPg);

            return this;
        }

        [AllureStep("ClickFButtonAddMdlWndwAddNewLctnPg")]
        public MdlWndwAddNewLocation ClickFButtonAddMdlWndwAddNewLctnPg()
        {
            Button.Click(ButtonAddMdlWndwAddNewLctnPg);

            return this;
        }

        private static IWebElement _element;

        [AllureStep("SelectorForClinicianMdlWndwAddNewLctn")]
        public static IList<IWebElement> SelectorForClinicianMdlWndwAddNewLctn(string _locationClinician)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@id= 'mat-autocomplete-0']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//mat-option[contains(@id, '{_locationClinician}')]"));
        }

        [AllureStep("SelectClinicianMdlWndwAddNewLctn")]
        public MdlWndwAddNewLocation SelectClinicianMdlWndwAddNewLctn(int clinician, string locationClinician)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _clinician = SelectorForClinicianMdlWndwAddNewLctn(locationClinician);

            _clinician[clinician].Click();

            return this;
        }
    }
}
