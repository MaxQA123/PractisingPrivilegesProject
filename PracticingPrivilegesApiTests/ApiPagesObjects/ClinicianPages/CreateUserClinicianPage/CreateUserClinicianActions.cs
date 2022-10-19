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

namespace PracticingPrivilegesApiTests.ApiPagesObjects.ClinicianPages.CreateUserClinicianPage
{
    public partial class CreateUserClinician
    {
        [AllureStep("RequestBody")]
        public static RequestCreateClinician RequestBody(List<long> numberRoles, string emailClinician, string firstName, string lastName, string phoneNumber, string type)
        {
            RequestCreateClinician payload = new()
            {
                Email = emailClinician,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                UserRoles = numberRoles,
                UserProfile = new()
                {
                    ProfileType = TestDataUserProfileForClinician.CLINICIAN,
                    AlternativeEmail = TestDataUserProfileForClinician.ALTERNATIVE_EMAIL,
                    AlternativePhoneNumber = TestDataUserProfileForClinician.ALTERNATIVE_PHONE_NUMBER,
                    GmcNumber = TestDataUserProfileForClinician.GMC_NUMBER,
                    ImcNumber = TestDataUserProfileForClinician.IMC_NUMBER,
                    Title = TestDataUserProfileForClinician.TITLE,
                    CurrentEmployer = new()
                    {
                        Id = TestDataUserProfileForClinician.CURRENT_EMPLOYER,
                    },
                    JobTitle = TestDataUserProfileForClinician.JOB_TITLE,
                    Restrictions = TestDataUserProfileForClinician.RESTRICTIONS,
                    ConsultingType = TestDataUserProfileForClinician.CONSULTING_TYPE,
                    PrimaryContact = new()
                    {
                        Id = TestDataUserProfileForClinician.PRIMARY_CONTACT,
                    },
                    Specialties = new()
                    {
                        Id = TestDataUserProfileForClinician.SPECIALTIES_SPECIALTY_ID,
                        Label = TestDataUserProfileForClinician.SPECIALTIES_SPECIALTY_LABEL,
                    }
                },
                Type = type  
            };
            return payload;
        }

        [AllureStep("ExecuteCreateClinicianAsSuperAdmin")]
        public static ResponseCreateClinician ExecuteCreateClinicianAsSuperAdmin(ResponseLogIn responseLogIn, List<long> numberRoles, string email, string firstName, string lastName, string phoneNumber, string type)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("/api/user/create", Method.Post);

            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddHeader("Authorization", "Bearer " + responseLogIn.accessToken);

            restRequest.AddJsonBody(RequestBody(numberRoles, email, firstName, lastName, phoneNumber, type));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseCreateClinician>(content);

            return dtoObject;
        }

        [AllureStep("ExecuteCreateClinicianAsAdmin")]
        public static ResponseCreateClinician ExecuteCreateClinicianAsAdmin(ResponceTwoStepAdmin responseTwoStep, List<long> numberRoles, string email, string firstName, string lastName, string phoneNumber, string type)
        {
            var restClient = new RestClient(EndPointsApi.apiHost);

            var restRequest = new RestRequest("/api/user/create", Method.Post);

            restRequest.AddHeaders(Headers.HeadersCommon());

            restRequest.AddHeader("Authorization", "Bearer " + responseTwoStep.accessToken);

            restRequest.AddJsonBody(RequestBody(numberRoles, email, firstName, lastName, phoneNumber, type));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusDescription == "Bad Request")
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseCreateClinician>(content);

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
