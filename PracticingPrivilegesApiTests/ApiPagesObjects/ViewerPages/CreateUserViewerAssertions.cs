using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.ViewerPages
{
    public partial class CreateUserViewer
    {
        [AllureStep("VerifyingCreateUserRandom")]
        public static void VerifyingCreateUserRandom(ResponsetCreateViewer response)
        {
            Assert.AreEqual("Successful operation.", response.Message);
        }
    }
}
