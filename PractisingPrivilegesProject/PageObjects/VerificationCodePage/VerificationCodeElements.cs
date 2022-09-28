using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.VerificationCodePage
{
    public partial class VerificationCode
    {
        [FindsBy(How = How.XPath, Using = "//input[@class = 'ng-untouched ng-pristine ng-invalid ng-star-inserted']")]
        public IWebElement FieldInputVerificationCodeVrfctnCdPg;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'mat-focus-indicator w100 mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtomSubmitVrfctnCdPg;
    }
}
