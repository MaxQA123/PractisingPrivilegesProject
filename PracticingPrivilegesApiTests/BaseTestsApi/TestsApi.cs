using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PracticingPrivilegesApiTests.ApiHelpers;
using PracticingPrivilegesApiTests.ApiPagesObjects.AdminPages.CreateUserAdminPage;
using PracticingPrivilegesApiTests.ApiPagesObjects.ApproverPages.CreateUserApproverPage;
using PracticingPrivilegesApiTests.ApiPagesObjects.ClinicianPages.CreateUserClinicianPage;
using PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage;
using PracticingPrivilegesApiTests.ApiPagesObjects.TwoStepApiAdminPage;
using PractisingPrivilegesProject.Helpers;
using RimuTec.Faker;
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
        [Retry(2)]
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

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiAdmin")]
        [AllureSubSuite("CreateUserAdmin")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The user in the role of admin had been created successfully.
        //Comment: 
        //Path to cheking's: 

        public void SuperAdminCreateUserAdmin()
        {
            var email = CredentialsApiSuperAdmin.emailSuperAdmin;

            var responseLogIn = LogInApi.ExecuteLogIn(email, CredentialsApiSuperAdmin.passwordSuperAdmin);

            LogInApi.VerifyingLoggedUserConst(responseLogIn);

            var emailAdmin = GenerateRandomDataHelper.RandomEmail(5) + TestDataEmailDomen.domenEmailXitroo;
            var firstName = Name.FirstName();
            var lastName = Name.LastName();
            var phoneNumber = GenerateRandomDataHelper.RandomPhoneNumber(10);
            List<int> numberRoles = CreateUserAdmin.CreateListRoles(TestDataForSelectRole.ROLE_ADMIN);
            var type = TestDataForCreateNewUser.TYPE_DATA_FOR_CREATE_USER;

            var responseCreateAdmin = CreateUserAdmin.ExecuteCreateAdmin(responseLogIn, numberRoles, emailAdmin, firstName, lastName, phoneNumber, type);

            CreateUserAdmin.VerifyingCreateUserRandom(responseCreateAdmin);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiAdmin")]
        [AllureSubSuite("AsSuperAdminCreateUserClinician")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The user in the role of clinician had been created successfully.
        //Comment: 
        //Path to cheking's: 

        public void AsSuperAdminCreateUserClinician()
        {
            var email = CredentialsApiSuperAdmin.emailSuperAdmin;

            var responseLogIn = LogInApi.ExecuteLogIn(email, CredentialsApiSuperAdmin.passwordSuperAdmin);

            LogInApi.VerifyingLoggedUserConst(responseLogIn);

            var emailAdmin = GenerateRandomDataHelper.RandomEmail(5) + TestDataEmailDomen.domenEmailXitroo;
            var firstName = Name.FirstName();
            var lastName = Name.LastName();
            var phoneNumber = GenerateRandomDataHelper.RandomPhoneNumber(10);
            List<long> numberRoles = CreateUserClinician.CreateListRoles(TestDataForSelectRole.ROLE_CLINICIAN);
            var type = TestDataForCreateNewUser.TYPE_DATA_FOR_CREATE_USER;

            var responseCreateClinician = CreateUserClinician.ExecuteCreateClinicianAsSuperAdmin(responseLogIn, numberRoles, emailAdmin, firstName, lastName, phoneNumber, type);

            CreateUserClinician.VerifyingCreateUserRandom(responseCreateClinician);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiAdmin")]
        [AllureSubSuite("AsAdminCreateUserClinician")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The user in the role of clinician had been created successfully.
        //Comment: 
        //Path to cheking's: 

        public void AsAdminCreateUserClinician()
        {
            var email = CredentialsApiAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneralApi.passwordGeneralCurrent);

            string code = responseLogIn.code;

            var responseTwoStep = TwoStepApiAdmin.ExecuteTwoStepLogIn(code, email, CredentialsApiAdmin.type);

            TwoStepApiAdmin.VerifyingLoggedUserConst(responseTwoStep);

            var emailAdmin = GenerateRandomDataHelper.RandomEmail(5) + TestDataEmailDomen.domenEmailXitroo;
            var firstName = Name.FirstName();
            var lastName = Name.LastName();
            var phoneNumber = GenerateRandomDataHelper.RandomPhoneNumber(10);
            List<long> numberRoles = CreateUserClinician.CreateListRoles(TestDataForSelectRole.ROLE_CLINICIAN);
            var type = TestDataForCreateNewUser.TYPE_DATA_FOR_CREATE_USER;

            var responseCreateClinician = CreateUserClinician.ExecuteCreateClinicianAsAdmin(responseTwoStep, numberRoles, emailAdmin, firstName, lastName, phoneNumber, type);

            CreateUserClinician.VerifyingCreateUserRandom(responseCreateClinician);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiAdmin")]
        [AllureSubSuite("AsSuperAdminCreateUserClinician")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The user in the role of clinician had been created successfully.
        //Comment: 
        //Path to cheking's: 

        public void AsSuperAdminCreateUserApprover()
        {
            var email = CredentialsApiSuperAdmin.emailSuperAdmin;

            var responseLogIn = LogInApi.ExecuteLogIn(email, CredentialsApiSuperAdmin.passwordSuperAdmin);

            LogInApi.VerifyingLoggedUserConst(responseLogIn);

            var emailApprover = GenerateRandomDataHelper.RandomEmail(5) + TestDataEmailDomen.domenEmailXitroo;
            var firstName = Name.FirstName();
            var lastName = Name.LastName();
            var phoneNumber = TestDataUserProfileForApprover.PHONE_NUMBER;
            long[] numberRoles = CreateUserApprover.CreateArrayRoles(TestDataForSelectRoleArray.ROLE_APPROVER);
            var type = TestDataForCreateNewUser.TYPE_DATA_FOR_CREATE_USER;

            var responseCreateApprover = CreateUserApprover.ExecuteCreateApproverAsSuperAdmin(responseLogIn, numberRoles, emailApprover, firstName, lastName, phoneNumber, type);

            CreateUserApprover.VerifyingCreateUserRandom(responseCreateApprover);
        }
    }
}