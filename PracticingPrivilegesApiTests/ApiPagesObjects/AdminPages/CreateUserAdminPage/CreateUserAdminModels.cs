using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.AdminPages.CreateUserAdminPage
{
    public class RequestCreateAdmin
    {
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public List<int> userRoles { get; set; }
        public List<string> userProfiles { get; set; }
        public string type { get; set; }
    }

    public class ResponseCreateAdmin
    {
        public string isSuccessful { get; set; }
        public string message { get; set; }
    }
}
