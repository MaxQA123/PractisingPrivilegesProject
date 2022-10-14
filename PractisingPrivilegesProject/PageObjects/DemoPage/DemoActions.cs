using NUnit.Allure.Attributes;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.DemoPage
{
    public partial class DemoTest
    {
        [AllureStep("SigningInAsClinician")]
        public DemoTest SigningInAsClinician()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataClinician.EMAIL_DEMO_TEST);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataGeneral.generalPassword);
            Button.Click(ButtonSignInLogInPg);

            return this;
        }

        [AllureStep("GetDemoFirstNameFromUserProfile")]
        public string GetDemoFirstNameFromUserProfile()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getFirstName = TextNameRoleOnHeader.Text.Substring(0, TextNameRoleOnHeader.Text.IndexOf(" "));
            string firstNameActual = getFirstName.ToString();

            Console.WriteLine(firstNameActual);

            return firstNameActual;
        }

        [AllureStep("GetDemoLastName")]
        public string GetDemoLastName()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getLastName = TextNameRoleOnHeader.Text;
            Regex regexGetLastName = new Regex(@"[^\s]+$");
            string lastNameActual = regexGetLastName.Match(getLastName).ToString();

            Console.WriteLine(lastNameActual);

            return lastNameActual;
        }
    }
}
