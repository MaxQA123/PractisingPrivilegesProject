using NUnit.Allure.Attributes;
using PractisingPrivileges.Helpers;
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
        [AllureStep("EnterPasswordRepeatPassword")]
        public SetPassword EnterPasswordRepeatPassword()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordSetPasswordPg, TestDataGeneral.generalPassword);
            InputGeneral.InputFunctionWithClear(FieldInputIRepeatPassworSetPassworddPg, TestDataGeneral.generalPassword);

            return this;
        }

        [AllureStep("ClickButtonSetPassworSetPassworddPg")]
        public SetPassword ClickButtonSetPassworSetPassworddPg()
        {
            Button.Click(ButtonSetPassworSetPassworddPg);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }
    }
}
