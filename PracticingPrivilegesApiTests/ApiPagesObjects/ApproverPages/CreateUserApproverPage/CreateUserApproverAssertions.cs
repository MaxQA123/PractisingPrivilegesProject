using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.ApproverPages.CreateUserApproverPage
{
    public partial class CreateUserApprover
    {
        [AllureStep("VerifyingCreateUserRandom")]
        public static void VerifyingCreateUserRandom(ResponseCreateApprover response)
        {
            Assert.AreEqual("Successful operation.", response.Message);
        }
    }
}
