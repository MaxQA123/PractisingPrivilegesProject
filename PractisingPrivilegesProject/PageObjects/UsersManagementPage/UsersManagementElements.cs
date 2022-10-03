using OpenQA.Selenium;
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
        [FindsBy(How = How.XPath, Using = "//button[@class = 'mat-focus-indicator mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtonCreateNewUserUsersMngmntPg;

        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Users management']")]
        public IWebElement TitleUsersManagmentUsrsMngmntPg;
    }
}
