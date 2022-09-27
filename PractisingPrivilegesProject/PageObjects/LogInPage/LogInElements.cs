using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.LogInPage
{
    public partial class LogIn
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        public IWebElement FieldInputEmailLogInPg;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Password']")]
        public IWebElement FieldInputPasswordLogInPg;

        [FindsBy(How = How.XPath, Using = "//button[@class= 'mat-focus-indicator w100 mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtonSignInLogInPg;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/auth/forgot-password']")]
        public IWebElement LinkForgotPasswordLogInPg;
    }
}
