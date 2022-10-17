using NUnit.Allure.Attributes;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.HeaderPage
{
    public partial class Header
    {
        [AllureStep("ClickTextNameRoleOnHeader")]
        public Header ClickTextNameRoleOnHeader()
        {
            Button.Click(TextNameRoleOnHeader);

            return this;
        }

        [AllureStep("LoggedFromAccountOnHeader")]
        public Header LoggedFromAccountOnHeader()
        {
            WaitUntil.WaitSomeInterval(3000);
            Button.Click(TextNameRoleOnHeader);
            Button.Click(ItemLogOutFromDropDownHeader);

            return this;
        }

        [AllureStep("GetFirstNameFromHeader")]
        public string GetFirstNameFromHeader()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getFirstName = TextNameRoleOnHeader.Text.Substring(0, TextNameRoleOnHeader.Text.IndexOf(" "));
            string firstNameActual = getFirstName.ToString();

            return firstNameActual;
        }

        [AllureStep("GetLastNameFromHeader")]
        public string GetLastNameFromHeader()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getLastName = TextNameRoleOnHeader.Text;
            Regex regexGetLastName = new Regex(@"[^\s]+$");
            string lastNameActual = regexGetLastName.Match(getLastName).ToString();

            return lastNameActual;
        }
    }
}
