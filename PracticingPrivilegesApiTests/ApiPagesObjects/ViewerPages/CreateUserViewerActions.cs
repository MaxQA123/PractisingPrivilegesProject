using Newtonsoft.Json;
using NUnit.Allure.Attributes;
using PracticingPrivilegesApiTests.ApiHelpers;
using PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage;
using PracticingPrivilegesApiTests.ApiPagesObjects.TwoStepApiAdminPage;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.ViewerPages
{
    public partial class CreateUserViewer
    {
        [AllureStep("RequestBody")]
        public static RequestCreateViewer RequestBody(List<long> numberRoles, string emailViewer, string firstName, string lastName, long phoneNumber, string type)
        {
            RequestCreateViewer payload = new()
            {
                Email = emailViewer,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                UserRoles = numberRoles,
                UserProfiles = new() { },
                Type = type
            };

            return payload;
        }

        [AllureStep("ExecuteCreateViewer")]
        public static ResponsetCreateViewer ExecuteCreateViewer(ResponceTwoStepAdmin responseTwoStep, List<long> numberRoles, string emailViewer, string firstName, string lastName, long phoneNumber, string type)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("/api/user/create", Method.Post);

            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddHeader("Authorization", "Bearer " + responseTwoStep.accessToken);

            restRequest.AddJsonBody(RequestBody(numberRoles, emailViewer, firstName, lastName, phoneNumber, type));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponsetCreateViewer>(content);

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
