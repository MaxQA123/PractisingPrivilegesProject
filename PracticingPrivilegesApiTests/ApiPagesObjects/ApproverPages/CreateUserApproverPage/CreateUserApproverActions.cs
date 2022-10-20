using Newtonsoft.Json;
using NUnit.Allure.Attributes;
using PracticingPrivilegesApiTests.ApiHelpers;
using PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.ApproverPages.CreateUserApproverPage
{
    public partial class CreateUserApprover
    {
        [AllureStep("RequestBody")]
        public static string RequestBody(List<long> numberRoles, string emailApprover, string firstName, string lastName, long phoneNumber, string type)
        {
            RequestCreateApprover payload = new RequestCreateApprover()
            {
                Email = emailApprover,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                UserRoles = numberRoles,
                UserProfiles = new List<UserProfile>()
                {
                    new UserProfile()
                    {
                    PersonalIdentificationNumber = TestDataUserProfileForApprover.PERSONAL_IDENTIFICATION_NUMBER,
                    ProfileType = TestDataUserProfileForApprover.APPROVER,
                    }
                    
                },
                Type = type
            };
            var payloadJson = JsonConvert.SerializeObject(payload);

            return payloadJson;
        }

        [AllureStep("ExecuteCreateApproverAsSuperAdmin")]
        public static ResponseCreateApprover ExecuteCreateApproverAsSuperAdmin(ResponseLogIn responseLogIn, List<long> numberRoles, string emailApprover, string firstName, string lastName, long phoneNumber, string type, string payloadJson)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("/api/user/create", Method.Post);

            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddHeader("Authorization", "Bearer " + responseLogIn.accessToken);

            restRequest.AddJsonBody(RequestBody(numberRoles, emailApprover, firstName, lastName, phoneNumber, type));
            
            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseCreateApprover>(content);

            return dtoObject;
        }

        public static List<long> CreateListRoles(long item)
        {
            List<long> role = new List<long>();

            role.Add(item);

            return role;
        }
    }
}