using NUnit.Allure.Attributes;
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
        [AllureStep("SigningInAsSuperAdmin")]
        public LogIn SigningInAsSuperAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataAdmin.emailSuperAdmin);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataAdmin.passwordSuperAdmin);
            Button.Click(IconShowPasswordLogInPg);
            Button.Click(ButtonSignInLogInPg);

            return this;
        }

        [AllureStep("SigningInAsAdmin")]
        public LogIn SigningInAsAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataAdmin.emailAdminQatester);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataGeneral.generalPassword);
            Button.Click(ButtonSignInLogInPg);

            return this;
        }

        [AllureStep("SigningInAsClinician")]
        public LogIn SigningInAsClinician()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataClinician.emailJaneClinician);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataGeneral.generalPassword);
            Button.Click(ButtonSignInLogInPg);

            return this;
        }

        [AllureStep("SigningInAsApprover")]
        public LogIn SigningInAsApprover()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataApprover.emailJaneApprover);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataGeneral.generalPassword);
            Button.Click(ButtonSignInLogInPg);

            return this;
        }

        [AllureStep("SigningInAsViewer")]
        public LogIn SigningInAsViewer()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataViewer.emailViewerViewer);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataGeneral.generalPassword);
            Button.Click(ButtonSignInLogInPg);

            return this;
        }

        [AllureStep("SigningInNewUserAfterCreating")]
        public LogIn SigningInNewUserAfterCreating(string _email)
        {
            WaitUntil.WaitSomeInterval(2000);
            FieldInputEmailLogInPg.SendKeys(_email);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataGeneral.generalPassword);
            Button.Click(IconShowPasswordLogInPg);
            Button.Click(ButtonSignInLogInPg);

            return this;
        }

        [AllureStep("SigningAfterChangingPassword")]
        public LogIn SigningAfterChangingPassword()
        {
            WaitUntil.WaitSomeInterval(2000);

            //InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataAdmin.emailAdminForTestingFrgtPsswrd);
            //InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataAdmin.passwordNewAdminForTestingFrgtPsswrd);

            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataClinician.emailClinicianForTestingFrgtPsswrd);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataClinician.passwordNewClinicianForTestingFrgtPsswrd);
            Button.Click(IconShowPasswordLogInPg);
            Button.Click(ButtonSignInLogInPg);

            return this;
        }

        [AllureStep("ClickLinkForgotPasswordLogInPg")]
        public LogIn ClickLinkForgotPasswordLogInPg()
        {
            Button.Click(LinkForgotPasswordLogInPg);

            return this;
        }
    }
}
