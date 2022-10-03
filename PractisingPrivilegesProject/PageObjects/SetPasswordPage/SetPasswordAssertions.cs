using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.SetPasswordPage
{
    public partial class SetPassword
    {
        [AllureStep("VerifyMessageChangePasswordSetPasswordPg")]
        public SetPassword VerifyMessageChangePasswordSetPasswordPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.IsTrue(Successfully.IsVisible(MessageChangePassworForSetPassworddPg));
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }
    }
}
