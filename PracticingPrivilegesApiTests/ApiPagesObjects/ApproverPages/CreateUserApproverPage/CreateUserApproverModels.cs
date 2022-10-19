using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.ApproverPages.CreateUserApproverPage
{
    public partial class RequestCreateApprover
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long PhoneNumber { get; set; }

        [JsonProperty("userRoles")]
        public long[] UserRoles { get; set; }

        [JsonProperty("userProfiles")]
        public UserProfile UserProfiles { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    
    public partial class UserProfile
    {
        [JsonProperty("profileType")]
        public string ProfileType { get; set; }

        [JsonProperty("personalIdentificationNumber")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long PersonalIdentificationNumber { get; set; }
    }

    public partial class ResponseCreateApprover
    {
        [JsonProperty("isSuccessful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
