using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.LocationsPage
{
    public partial class Locations
    {
        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Locations']")]
        public IWebElement TitleLocationsLctnsPg;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'mat-focus-indicator mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtonAddNewLocationLctnsPg;

        IWebElement NameLocationLctnsPg => Browser._Driver.FindElement(_NameLocationLctnsPg);
        public static readonly By _NameLocationLctnsPg = By.XPath("//tbody[@role = 'rowgroup']//tr[last()]//td");
    }
}
