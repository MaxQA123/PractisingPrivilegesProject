using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.VerificationCodePage
{
    public partial class VerificationCode
    {
        [AllureStep("ConfirmVerificationCode")]
        public VerificationCode VerifySuccessfullyEnterCodeVrfctnCdPg()
        {
            Assert.IsTrue(Errors.IsInvisible(MessageInvalidLoginAttemptVrfctnCdPg));

            return this;
        }
    }
}
