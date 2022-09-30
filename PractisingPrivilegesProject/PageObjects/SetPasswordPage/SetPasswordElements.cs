using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.SetPasswordPage
{
    public partial class SetPassword
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder= 'Password']")]
        public IWebElement FieldInputPasswordSetPasswordPg;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder= 'Repeat password']")]
        public IWebElement FieldInputIRepeatPassworSetPassworddPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'mat-focus-indicator red-btn w100 mat-flat-button mat-button-base mat-primary ng-star-inserted']")]
        public IWebElement ButtonSetPassworSetPassworddPg;
    }
}
