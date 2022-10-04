using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewLocationPage
{
    public partial class MdlWndwAddNewLocation
    {
        [AllureStep("VerifyMessageChangePasswordSetPasswordPg")]
        public MdlWndwAddNewLocation VerifyMessageLocationCreatedMdlWndwAddNewLctnPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.IsTrue(Successfully.IsVisible(MessageLocationCreatedMdlWndwAddNewLctnPg));

            return this;
        }
    }
}