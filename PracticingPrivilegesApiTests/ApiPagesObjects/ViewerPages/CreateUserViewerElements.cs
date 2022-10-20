using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.ViewerPages
{
    public partial class RequestCreateViewer
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public long PhoneNumber { get; set; }

        [JsonProperty("userRoles")]
        public List<long> UserRoles { get; set; }

        [JsonProperty("userProfiles")]
        public List<object> UserProfiles { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class ResponsetCreateViewer
    {
        [JsonProperty("isSuccessful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
