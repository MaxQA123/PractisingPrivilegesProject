﻿using NUnit.Allure.Attributes;
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
    }
}
