using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage;
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

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleViewer(nameRoleCompare);

            Thread.Sleep(5000);
        }
    }
}
