using OpenQA.Selenium;
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
    }
}
