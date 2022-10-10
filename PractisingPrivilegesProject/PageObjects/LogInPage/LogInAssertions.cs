using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.LogInPage
{
    public partial class LogIn
    {
        [AllureStep("VerifySuccessLogIn")]
        public void VerifySuccessLogIn()
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(Errors.IsInvisible(MessageYouMustEnterValueLogInPg));
                Assert.IsTrue(Errors.IsInvisible(MessageInvaldLoginAttempLogInPg));
            });
        }
    }
}
