using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewLocationPage
{
    public partial class MdlWndwAddNewLocation
    {
        IWebElement FieldInputNameLocationMdlWndwAddNewLctnPg => Browser._Driver.FindElement(_FieldInputNameLocationMdlWndwAddNewLctnPg);
        public static readonly By _FieldInputNameLocationMdlWndwAddNewLctnPg = By.XPath("//input[@name = 'Name']");

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Add clinician...']")]
        public IWebElement DropDownAddClinicianMdlWndwAddNewLctnPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'mat-focus-indicator mat-flat-button mat-button-base mat-primary ng-star-inserted']")]
        public IWebElement ButtonAddMdlWndwAddNewLctnPg;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label = 'Location created']")]
        public IWebElement MessageLocationCreatedMdlWndwAddNewLctnPg;
    }
}