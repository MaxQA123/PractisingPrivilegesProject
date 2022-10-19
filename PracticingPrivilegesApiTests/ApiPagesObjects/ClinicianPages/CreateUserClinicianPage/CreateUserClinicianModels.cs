using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.ClinicianPages.CreateUserClinicianPage
{
    public partial class RequestCreateClinician
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("userRoles")]
        public List<long> UserRoles { get; set; }

        [JsonProperty("userProfiles")]
        public UserProfiles UserProfile { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public partial class UserProfiles
    {
        [JsonProperty("profileType")]
        public string ProfileType { get; set; }

        [JsonProperty("alternativeEmail")]
        public string AlternativeEmail { get; set; }

        [JsonProperty("alternativePhoneNumber")]
        public string AlternativePhoneNumber { get; set; }

        [JsonProperty("gmcNumber")]
        public long GmcNumber { get; set; }

        [JsonProperty("imcNumber")]
        public long ImcNumber { get; set; }

        [JsonProperty("title")]
        public long Title { get; set; }

        [JsonProperty("currentEmployer")]
        public CurrentEmployer CurrentEmployer { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("restrictions")]
        public string Restrictions { get; set; }

        [JsonProperty("consultingType")]
        public long ConsultingType { get; set; }

        [JsonProperty("primaryContact")]
        public CurrentEmployer PrimaryContact { get; set; }

        [JsonProperty("specialties")]
        public Specialty Specialties { get; set; }

        [JsonProperty("locations")]
        public CurrentEmployer Locations { get; set; }

        [JsonProperty("specialities")]
        public CurrentEmployer Specialities { get; set; }
    }

    public partial class CurrentEmployer
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public partial class Specialty
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public partial class ResponseCreateClinician
    {
        [JsonProperty("isSuccessful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
