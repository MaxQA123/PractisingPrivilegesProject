using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwSelectSpecialtiesPage
{
    public partial class MdlWndwSelectSpecialties
    {
        [FindsBy(How = How.XPath, Using = "//button[@class= 'mat-focus-indicator mat-flat-button mat-button-base mat-primary ng-star-inserted']")]
        public IWebElement ButtonAddMdlWndwSpecialtiesLocations;
    }
}
