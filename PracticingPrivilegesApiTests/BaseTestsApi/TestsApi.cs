using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PracticingPrivilegesApiTests.ApiHelpers;
using PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage;
using PracticingPrivilegesApiTests.ApiPagesObjects.TwoStepApiAdminPage;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticingPrivilegesApiTests.BaseTestsApi
{
    [TestFixture]
    [AllureNUnit]

    public class TestsApi
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiAdmin")]
        [AllureSubSuite("LoginConstDataAsSuperAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void MakeLogInAsSuperAdmin()
        {
            var email = CredentialsApiSuperAdmin.emailSuperAdmin;

            var responseLogIn = LogInApi.ExecuteLogIn(email, CredentialsApiSuperAdmin.passwordSuperAdmin);

            LogInApi.VerifyingLoggedUserConst(responseLogIn);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiAdmin")]
        [AllureSubSuite("LoginConstDataAsAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void MakeLogInAsAdmin()
        {
            var email = CredentialsApiAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneralApi.passwordGeneralCurrent);

            string code = responseLogIn.code;

            var responseTwoStep = TwoStepApiAdmin.ExecuteTwoStepLogIn(code, email, CredentialsApiAdmin.type);

            TwoStepApiAdmin.VerifyingLoggedUserConst(responseTwoStep);
        }
    }
}