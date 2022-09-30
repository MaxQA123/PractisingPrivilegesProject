using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.Helpers
{
    public class EndPoints
    {
        public const string urlWebSite = "https://practicingprivileges.azurewebsites.net/auth/sign-in";
        public const string urlRandomEmail = "https://xitroo.com/";
        public const string urlConstEmail = "https://xitroo.com/#liludalastfg@xitroo.com";
    }

    public class TestDataGeneral
    {
        public const string generalPassword = "Qwerty123!";
    }

    public class TestDataAdmin
    {
        public const string emailSuperAdmin = "super.admin@dev.com";
        public const string passwordSuperAdmin = "Jupiter1405!";

        public const string emailAdminQatester = "qatester91311@xitroo.com";

        public const string userNameRoleAdmin = "Admin";
        public const string userNameRoleSuperAdmin = "Super Admin";
    }

    public class TestDataClinician
    {
        public const string firstNameClinician = "Clin";
        public const string lastNameClinician = "Clin";
    }

    public class TestDataApprover
    {
        public const string firstNameApprover = "Test-Approver";
        public const string lastNameApprover = "Approver";
        public const string personalIdentificationNumber = "1";
    }

    public class TestDataViewer
    {
        public const string firstNameViewer = "Test-Viewer";
        public const string lastNameViewer = "Viewer";
    }

    public class TestDataEmailDomen
    {
        public const string domenEmailXitroo = "@xitroo.com";
    }
}
