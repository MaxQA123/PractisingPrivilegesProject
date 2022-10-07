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
        [AllureStep("VerifyEnteredDataEmailPassword")]
        public LogIn VerifyEnteredDataEmailPassword()
        {
            Assert.IsTrue(Errors.IsInvisible(MessageYouMustEnterValueLogInPg));

            return this;
        }

        [AllureStep("VerifySuccessLogIn")]
        public LogIn VerifySuccessLogIn()
        {
            Assert.IsTrue(Errors.IsInvisible(MessageInvaldLoginAttempLogInPg));

            return this;
        }
    }
}
