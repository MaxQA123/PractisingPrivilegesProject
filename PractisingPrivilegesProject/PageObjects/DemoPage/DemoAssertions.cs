using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects
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

        [AllureStep("VerifyDemoLogin")]
        public DemoTest VerifyDemoLogin()
        {
            WaitUntil.WaitSomeInterval(2000);

            Assert.IsTrue(Errors.IsInvisible(MessageInvaldLoginAttempLogInPg));

            return this;
        }

        //[AllureStep("VerifyDemoExeptionFail")]
        //public DemoTest VerifyDemoExeptionFail()
        //{
        //    Assert.That(() => DoSomethingThatMayNotWork(), Throws.Nothing);
        //}

    }
}
