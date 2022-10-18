using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.TwoStepApiAdminPage
{
    public partial class TwoStepApiAdmin
    {
        [AllureStep("VerifyingLoggedUserConst")]
        public static void VerifyingLoggedUserConst(ResponceTwoStepAdmin response)
        {
            Assert.AreEqual("Successful operation.", response.message);
        }
    }
}
