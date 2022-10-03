using OpenQA.Selenium;
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
    }
}
