using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.TwoStepApiAdminPage
{
    public class RequestTwoStepAsAdmin
    {
        public string code { get; set; }
        public string email { get; set; }
        public string type { get; set; }
    }

    public class ResponceTwoStepAdmin
    {
        public string accessToken { get; set; }
        public string isSuccessful { get; set; }
        public string message { get; set; }
    }
}
