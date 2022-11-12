using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.UsersManagementPage
{
    public partial class UsersManagement
    {
        [FindsBy(How = How.XPath, Using = "//button[@class = 'mat-focus-indicator mat-flat-button mat-button-base mat-primary ng-star-inserted']")]
        public IWebElement ButtonCreateNewUserUsersMngmntPg;

        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Users management']")]
        public IWebElement TitleUsersManagmentUsrsMngmntPg;

        [FindsBy(How = How.XPath, Using = "//table//tbody//tr[last()]")]
        public IWebElement LastUserInListUserstUsrsMngmntPg;

        //[FindsBy(How = How.XPath, Using = "//input[contains(@id, 'mat-input')]")]
        //public IWebElement FieldInputSearchUsrsMngmntPg;

        IWebElement FieldInputSearchUsrsMngmntPg => Browser._Driver.FindElement(_FieldInputSearchUsrsMngmntPg);
        public static readonly By _FieldInputSearchUsrsMngmntPg = By.XPath("//input[contains(@id, 'mat-input')]");

    }
}
