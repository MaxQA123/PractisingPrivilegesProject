using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PracticingPrivilegesApiTests.ApiHelpers;
using PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage;
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

            var payload = LogInApi.GetUserData(email, CredentialsApiSuperAdmin.passwordSuperAdmin);

            var response = LogInApi.ExecuteLogIn(payload);

            LogInApi.VerifyingLoggedUserConst(response);
        }
    }

}