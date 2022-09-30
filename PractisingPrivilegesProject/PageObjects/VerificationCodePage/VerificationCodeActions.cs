using NUnit.Allure.Attributes;
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
        public VerificationCode ConfirmVerificationCode(string _verificationCode)
        {
            WaitUntil.WaitSomeInterval(1000);
            FieldInputVerificationCodeVrfctnCdPg.SendKeys(_verificationCode);
            Button.Click(ButtomSubmitVrfctnCdPg);
            
            return this;
        }
    }
}
