using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiHelpers
{
    public class EndPointsApi
    {
        public const string apiHost = "https://practicingprivilegesapi.azurewebsites.net";
    }
    public class CredentialsApiSuperAdmin
    {
        public const string emailSuperAdmin = "super.admin@dev.com";
        public const string passwordSuperAdmin = "Jupiter1405!";
    }

    public class RequestGeneralTestDataProfileSetUp
    {
        public const string firstNameTeacher = "TestTeacher";
        public const string lastNameTeacher = "NewTeacher";
    }

    public class ResponseTestsData
    {
        public const string responseForSignUpStudent = "Account created";
    }
}
