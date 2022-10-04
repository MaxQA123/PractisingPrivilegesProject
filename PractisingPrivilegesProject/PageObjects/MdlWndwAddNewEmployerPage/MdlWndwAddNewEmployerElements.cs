using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewEmployerPage
{
    public partial class MdlWndwAddNewEmployer
    {
        IWebElement FieldInputNameEmployerMdlWndwAddNewEmplrPg => Browser._Driver.FindElement(_FieldInputNameEmployerMdlWndwAddNewEmplrPg);
        public static readonly By _FieldInputNameEmployerMdlWndwAddNewEmplrPg = By.XPath("//input[@name = 'Name']");

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Add clinician...']")]
        public IWebElement DropDownAddClinicianMdlWndwAddNewEmplrPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'mat-focus-indicator mat-flat-button mat-button-base mat-primary ng-star-inserted']")]
        public IWebElement ButtonAddMdlWndwAddNewEmplrPg;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label = 'Employer successfully created']")]
        public IWebElement MessageEmployerCreatedMdlWndwAddNewEmplrPg;
    }
}
