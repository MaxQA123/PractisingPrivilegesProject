using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage
{
    public class RequestLogIn
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class ResponseLogIn
    {
        public string accessToken { get; set; }
        public string requiresTwoFactor { get; set; }
        public string code { get; set; }
        public string isSuccessful { get; set; }
        public string message { get; set; }
    } 
}
