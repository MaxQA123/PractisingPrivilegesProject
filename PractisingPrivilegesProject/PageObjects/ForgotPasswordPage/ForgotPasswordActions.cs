using NUnit.Allure.Attributes;
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
        [AllureStep("EnterEmailOnFrgtPsswrdPg")]
        public ForgotPassword EnterEmailOnFrgtPsswrdPg()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailFrgtPsswrdPg, TestDataViewer.emailViewerForTestingFrgtPsswrd);

            return this;
        }

        [AllureStep("ClickButtonRequestOKFrgtPsswrdPg")]
        public ForgotPassword ClickButtonRequestOKFrgtPsswrdPg()
        {
            Button.Click(ButtonRequestFrgtPsswrdPg);
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonOkFrgtPsswrdPg);

            return this;
        }
    }
}
