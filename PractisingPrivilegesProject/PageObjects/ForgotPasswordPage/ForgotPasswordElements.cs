using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.ForgotPasswordPage
{
    public partial class ForgotPassword
    {
        //[FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        //public IWebElement FieldInputEmailFrgtPsswrdPg;

        IWebElement FieldInputEmailFrgtPsswrdPg => Browser._Driver.FindElement(_FieldInputEmailFrgtPsswrdPg);
        public static readonly By _FieldInputEmailFrgtPsswrdPg = By.XPath("//input[@placeholder = 'Email']");

        [FindsBy(How = How.XPath, Using = "//button[@class= 'mat-focus-indicator w100 mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtonRequestFrgtPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Forgot password?']")]
        public IWebElement TitleForgotpasswordFrgtPsswrdPg;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'mat-focus-indicator w100 mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtonOkFrgtPsswrdPg;
    }
}
