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

namespace PracticingPrivilegesApiTests.ApiPagesObjects.AdminPages.CreateUserAdminPage
{
    public partial class CreateUserAdmin
    {
        [AllureStep("RequestBody")]
        public static RequestCreateAdmin RequestBody(List<int> numberRoles, string emailAdmin, string firstName, string lastName, string phoneNumber, string type)
        {
            RequestCreateAdmin payload = new()
            {
                email = emailAdmin,
                firstName = firstName,
                lastName = lastName,
                phoneNumber = phoneNumber,
                userRoles = numberRoles,
                userProfiles = new() { },
                type = type
            };

            return payload;
        }

        [AllureStep("ExecuteCreateAdmin")]
        public static ResponseCreateAdmin ExecuteCreateAdmin(ResponseLogIn responseLogIn, List<int> numberRoles, string email, string firstName, string lastName, string phoneNumber, string type)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("/api/user/create", Method.Post);

            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddHeader("Authorization", "Bearer " + responseLogIn.accessToken);

            restRequest.AddJsonBody(RequestBody(numberRoles, email, firstName, lastName, phoneNumber,type));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseCreateAdmin>(content);

            return dtoObject;
        }

        public static List<int> CreateListRoles(int item)
        {
            List<int> role = new List<int>();

            role.Add(item);

            return role;
        }
    }
}