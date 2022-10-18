using Newtonsoft.Json;
using NUnit.Allure.Attributes;
using PracticingPrivilegesApiTests.ApiHelpers;
using PracticingPrivilegesApiTests.ApiPagesObjects.TwoStepApiAdminPage;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.TwoStepApiAdminPage
{
    public partial class TwoStepApiAdmin
    {
        [AllureStep("RequestBody")]
        public static RequestTwoStepAsAdmin RequestBody(string code, string email, string type)
        {
            var payload = new RequestTwoStepAsAdmin();
            payload.code = code;
            payload.email = email;
            payload.type = type;

            return payload;
        }

        [AllureStep("ExecuteTwoStepLogIn")]
        public static ResponceTwoStepAdmin ExecuteTwoStepLogIn(string code, string email, string type)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("/api/identity/twoStepSignIn", Method.Post);

            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddJsonBody(RequestBody(code, email, type));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponceTwoStepAdmin>(content);

            return dtoObject;
        }
    }
}
