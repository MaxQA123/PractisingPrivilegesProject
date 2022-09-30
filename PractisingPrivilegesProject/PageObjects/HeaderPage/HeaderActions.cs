using NUnit.Allure.Attributes;
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
    }
}
