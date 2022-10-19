using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.ClinicianPages.CreateUserClinicianPage
{
    public partial class CreateUserClinician
    {
        [AllureStep("VerifyingCreateUserRandom")]
        public static void VerifyingCreateUserRandom(ResponseCreateClinician response)
        {
            Assert.AreEqual("Successful operation.", response.Message);
        }
    }
}
