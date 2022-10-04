using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.EmployersPage
{
    public partial class Employers
    {
        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Employers']")]
        public IWebElement TitleEmployersEmplrsPg;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'mat-focus-indicator mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtonAddNewEmployerEmplrsPg;

        IWebElement NameEmployerLctnsPg => Browser._Driver.FindElement(_NameEmployerLctnsPg);
        public static readonly By _NameEmployerLctnsPg = By.XPath("//tbody[@role = 'rowgroup']//tr[last()]//td");
    }
}
