using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.ForgotPasswordPage
{
    public partial class ForgotPassword
    {
        [AllureStep("VerifyTitleForgotPasswordPg")]
        public ForgotPassword VerifyTitleForgotPasswordPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.IsTrue(Successfully.IsVisible(TitleForgotpasswordFrgtPsswrdPg));

            return this;
        }
    }
}
