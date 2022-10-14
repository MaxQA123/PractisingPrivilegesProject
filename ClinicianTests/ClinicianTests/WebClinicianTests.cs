using Allure.Commons;
using ClinicianTests;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using PractisingPrivilegesProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClinicianTests
{
    [TestFixture]
    [AllureNUnit]

    public class WebClinicianTests : WebBaseClinician
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Clinician")]
        [AllureSubSuite("LogInAsClinician")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as clinician.
        //Comment: 

        public void LogInAsClinician()
        {
            Pages.LogIn
                .SigningInAsClinician();

            var email = TestDataClinician.emailJaneClinician;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string firstName = Pages.Header.GetFirstNameFromHeadere();

            Pages.Header
                .VerifyFirstNameClinician(firstName);

            WaitUntil.WaitSomeInterval(3000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Clinician")]
        [AllureSubSuite("ForgotPasswordClinician")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has been changed password.
        //Comment: 

        public void ForgotPasswordClinician()
        {
            Pages.LogIn
                .ClickLinkForgotPasswordLogInPg();
            Pages.ForgotPassword
                .VerifyTitleForgotPasswordPg()
                .EnterEmailOnFrgtPsswrdPg();
            Pages.ForgotPassword
                .ClickButtonRequestOKFrgtPsswrdPg();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlConstEmailClinicianFrgtPsswrd);
            Pages.EmailXitroo
                .EnterEmail()
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickLinkResetPassword();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningAfterChangingPassword();

            var email = TestDataClinician.emailClinicianForTestingFrgtPsswrd;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataClinician.passwordNewClinicianForTestingFrgtPsswrd);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            Thread.Sleep(5000);
        }
    }
}
