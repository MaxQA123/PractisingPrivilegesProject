using Allure.Commons;
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
using ViewerTests;

namespace ViewerTests
{
    [TestFixture]
    [AllureNUnit]

    public class WebViewerTests : WebBaseViewer
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Viewer")]
        [AllureSubSuite("LogInAsViewer")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as Viewer.
        //Comment: 

        public void LogInAsViewer()
        {
            Pages.LogIn
                .SigningInAsViewer();

            var email = TestDataViewer.emailViewerViewer;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string firstName = Pages.Header.GetFirstNameFromHeadere();

            Pages.Header
                .VerifyNameRoleViewer(firstName);

            WaitUntil.WaitSomeInterval(3000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Viewer")]
        [AllureSubSuite("ForgotPasswordViewer")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has been changed password.
        //Comment: 

        public void ForgotPasswordViewer()
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
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlConstEmailViewerFrgtPssword);
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

            var email = TestDataViewer.emailViewerForTestingFrgtPsswrd;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalNewPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            WaitUntil.WaitSomeInterval(3000);
        }
    }
}
