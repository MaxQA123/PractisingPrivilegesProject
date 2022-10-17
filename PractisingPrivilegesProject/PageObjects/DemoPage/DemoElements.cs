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
        //[FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        //public IWebElement FieldInputEmailLogInPg;

        IWebElement FieldInputEmailLogInPg => Browser._Driver.FindElement(_FieldInputEmailLogInPg);
        public static readonly By _FieldInputEmailLogInPg = By.XPath("//input[@placeholder = 'Email']");

        //[FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Password']")]
        //public IWebElement FieldInputPasswordLogInPg;

        IWebElement FieldInputPasswordLogInPg => Browser._Driver.FindElement(_FieldInputPasswordLogInPg);
        public static readonly By _FieldInputPasswordLogInPg = By.XPath("//input[@placeholder = 'Password']");

        //[FindsBy(How = How.XPath, Using = "//button[@class= 'mat-focus-indicator w100 mat-flat-button mat-button-base mat-primary']")]
        //public IWebElement ButtonSignInLogInPg;

        IWebElement ButtonSignInLogInPg => Browser._Driver.FindElement(_ButtonSignInLogInPg);
        public static readonly By _ButtonSignInLogInPg = By.XPath("//button[@class= 'mat-focus-indicator w100 mat-flat-button mat-button-base mat-primary']");

        public IWebElement TextNameRoleOnHeader => Browser._Driver.FindElement(_TextNameRoleOnHeader);
        public readonly static By _TextNameRoleOnHeader = By.XPath("//div[@class = 'mat-menu-trigger avatar']//span");

        IWebElement FieldInputLastNamePrflPg => Browser._Driver.FindElement(_FieldInputLastNamePrflPg);
        public static readonly By _FieldInputLastNamePrflPg = By.XPath("Last name");

        IWebElement MessageInvaldLoginAttempLogInPg => Browser._Driver.FindElement(_MessageInvaldLoginAttempLogInPg);
        public static readonly By _MessageInvaldLoginAttempLogInPg = By.XPath("//div[contains(@aria-label, 'Invalid login attempt.')]");

        //[FindsBy(How = How.XPath, Using = "//div[contains(@aria-label, 'Invalid login attempt.')]")]
        //public IWebElement MessageInvaldLoginAttempLogInPg;
    }
}
