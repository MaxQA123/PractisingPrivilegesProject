using NUnit.Allure.Attributes;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public string GetFirstNameFromHeadere()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getFirstName = TextNameRoleOnHeader.Text.Substring(0, TextNameRoleOnHeader.Text.IndexOf(" "));
            string firstNameActual = getFirstName.ToString();

            Console.WriteLine(firstNameActual);

            return firstNameActual;
        }
    }
}
