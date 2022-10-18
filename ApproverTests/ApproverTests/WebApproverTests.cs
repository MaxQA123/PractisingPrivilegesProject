using Allure.Commons;
using ApproverTests;
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

namespace ApproverTests
{
    [TestFixture]
    [AllureNUnit]

    public class WebApproverTests : WebBaseApprover
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Approver")]
        [AllureSubSuite("LogInAsApprover")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as Approver.
        //Comment: 

        public void LogInAsApprover()
        {
            Pages.LogIn
                .SigningInAsApprover();

            var email = TestDataApprover.emailJaneApprover;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string firstName = Pages.Header.GetFirstNameFromHeader();

            Pages.Header
                .VerifyNameRoleApprover(firstName);

            WaitUntil.WaitSomeInterval(3000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Approver")]
        [AllureSubSuite("ForgotPasswordApprover")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has been changed password.
        //Comment: 

        public void ForgotPasswordApprover()
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
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlConstEmailApproverFrgtPssword);
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

            var email = TestDataApprover.emailApproverForTestingFrgtPsswrd;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalNewPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            WaitUntil.WaitSomeInterval(3000);
        }
    }
}
