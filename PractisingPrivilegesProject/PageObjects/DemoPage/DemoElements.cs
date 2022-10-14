using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.DemoPage
{
    public partial class DemoTest
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        public IWebElement FieldInputEmailLogInPg;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Password']")]
        public IWebElement FieldInputPasswordLogInPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'mat-focus-indicator w100 mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtonSignInLogInPg;

        public IWebElement TextNameRoleOnHeader => Browser._Driver.FindElement(_TextNameRoleOnHeader);
        public readonly static By _TextNameRoleOnHeader = By.XPath("//div[@class = 'mat-menu-trigger avatar']//span");
    }
}
