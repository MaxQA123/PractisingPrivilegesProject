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
        //https://practicingprivilegesapi.azurewebsites.net
    }

    public class TestDataGeneralApi
    {
        public const string passwordGeneralCurrent = "Qwerty123!";
        public const string passwordGeneralNew = "!123Qwerty";
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

    public class TestDataForSelectRole
    {
        public const int ROLE = 0;
        public const int ROLE_NEXT= 1;
        public const int ROLE_ADMIN = 2;
        public const int nextWithTopOfListThird = 3;
    }

    public class TestDataForCreateNewUser
    {
        public const string TYPE_DATA_FOR_CREATE_USER = "[USERS MANAGEMENT] [API] user create";
    }
}
