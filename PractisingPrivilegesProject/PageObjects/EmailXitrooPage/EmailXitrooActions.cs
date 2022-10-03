using NUnit.Allure.Attributes;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.EmailXitrooPage
{
    public partial class EmailXitroo
    {
        [AllureStep("EnterEmail")]
        public EmailXitroo EnterEmail(string _email)
        {
            WaitUntil.WaitSomeInterval(3000);
            WaitUntil.ShouldLocate(_FieldInputEmail);
            FieldInputEmail.SendKeys(_email);

            return this;
        }

        [AllureStep("EnterEmail")]
        public EmailXitroo EnterEmail()
        {
            WaitUntil.WaitSomeInterval(3000);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, TestDataClinician.emailClinicianForTestingFrgtPsswrd);
            
            return this;
        }

        [AllureStep("ClickSearchButton")]
        public EmailXitroo ClickSearchButton()
        {
            WaitUntil.ShouldLocate(_ButtonSearchEmail);
            ButtonSearchEmail.Click();

            return this;
        }

        [AllureStep("OpenNewlyLetter")]
        public EmailXitroo OpenNewlyLetter()
        {
            WaitUntil.WaitSomeInterval(10000);
            WaitUntil.ElementIsClickable(SelectLetterNumberOneNew);
            SelectLetterNumberOneNew.Click();

            return this;
        }

        [AllureStep("ClickButtonConfirmEmailFromEmail")]
        public EmailXitroo ClickButtonConfirmEmailFromEmail()
        {
            WaitUntil.WaitSomeInterval(3000);
            Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.ElementIsClickable(ButtonConfirmEmailFromEmail);
            ButtonConfirmEmailFromEmail.Click();
            Browser._Driver.SwitchTo().DefaultContent();

            return this;
        }

        [AllureStep("ClickLinkResetPassword")]
        public EmailXitroo ClickLinkResetPassword()
        {
            WaitUntil.WaitSomeInterval(3000);
            Browser._Driver.SwitchTo().Frame(IframeXitrooLetter);
            WaitUntil.ElementIsClickable(LinkResetPassword);
            LinkResetPassword.Click();
            Browser._Driver.SwitchTo().DefaultContent();

            return this;
        }
    }
}