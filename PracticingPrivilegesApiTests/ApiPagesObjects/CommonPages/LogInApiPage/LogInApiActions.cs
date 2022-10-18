    using Newtonsoft.Json;
using NUnit.Allure.Steps;
using PracticingPrivilegesApiTests.ApiHelpers;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


namespace PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage
{
    public partial class LogInApi
    {
        [AllureStep("RequestBody")]
        public static RequestLogIn RequestBody(string email, string password)
        {
            var payload = new RequestLogIn();
            payload.email = email;
            payload.password = password;

            return payload;
        }

        [AllureStep("ExecuteLogIn")]
        public static ResponseLogIn ExecuteLogIn(string email, string password)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("/api/identity/signIn", Method.Post);

            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddJsonBody(RequestBody(email, password));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseLogIn>(content);

            return dtoObject;
        }
    }
}
