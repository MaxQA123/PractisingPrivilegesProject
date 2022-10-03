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

        [FindsBy(How = How.XPath, Using = "//app-input[@placeholder = 'Password']//mat-icon[@class = 'mat-icon notranslate pointer material-icons mat-icon-no-color ng-star-inserted']")]
        public IWebElement IconShowPasswordSetPasswordPg;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder= 'Repeat password']")]
        public IWebElement FieldInputIRepeatPassworSetPassworddPg;

        [FindsBy(How = How.XPath, Using = "//app-input[@placeholder = 'Repeat password']//mat-icon[@class = 'mat-icon notranslate pointer material-icons mat-icon-no-color ng-star-inserted']")]
        public IWebElement IconShowRepeatPasswordSetPasswordPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'mat-focus-indicator red-btn w100 mat-flat-button mat-button-base mat-primary ng-star-inserted']")]
        public IWebElement ButtonSetPassworSetPassworddPg;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label = 'Your password has been successfully changed']")]
        public IWebElement MessageChangePassworForSetPassworddPg;
    }
}
