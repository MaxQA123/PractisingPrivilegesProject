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

    public class TestDataGeneralApi
    {
        public const string passwordGeneralCurrent = "Qwerty123!";
    }
    public class CredentialsApiSuperAdmin
    {
        public const string emailSuperAdmin = "super.admin@dev.com";
        public const string passwordSuperAdmin = "Jupiter1405!";
    }

    public class CredentialsApiAdmin
    {
        public const string emailAdminQatester = "qatester91311@xitroo.com";
        public const string type = "[AUTH] verification code";
    }

    public class ResponseTestsData
    {
        public const string responseForSignUpStudent = "Account created";
    }
}
