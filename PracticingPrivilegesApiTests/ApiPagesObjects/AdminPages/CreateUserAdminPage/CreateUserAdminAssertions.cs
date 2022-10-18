using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.AdminPages.CreateUserAdminPage
{
    public partial class CreateUserAdmin
    {
        [AllureStep("VerifyingCreateUserRandom")]
        public static void VerifyingCreateUserRandom(ResponseCreateAdmin response)
        {
            Assert.AreEqual("Successful operation.", response.message);
        }
    }
}
