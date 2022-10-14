using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.DemoPage
{
    public partial class DemoTest
    {
        [AllureStep("VerifyDemo")]
        public DemoTest VerifyDemo(string getNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(2000);
            string nameRoleExpected = TestDataClinician.USER_NAME_DEMO_TEST;

            Assert.AreEqual(nameRoleExpected, getNameRoleActual);

            return this;
        }
    }
}
