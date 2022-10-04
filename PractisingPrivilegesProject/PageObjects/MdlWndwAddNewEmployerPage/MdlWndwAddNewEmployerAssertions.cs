using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewEmployerPage
{
    public partial class MdlWndwAddNewEmployer
    {
        [AllureStep("VerifyMessageEmployerCreatedMdlWndwAddNewEmplrPg")]
        public MdlWndwAddNewEmployer VerifyMessageEmployerCreatedMdlWndwAddNewEmplrPg()
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.IsTrue(Successfully.IsVisible(MessageEmployerCreatedMdlWndwAddNewEmplrPg));

            return this;
        }

        [AllureStep("GetNameEmployerMdlWndwAddNewEmplrPg")]
        public string GetNameEmployerMdlWndwAddNewEmplrPg()
        {
            WaitUntil.WaitSomeInterval(500);
            string getNameLocation = TestDataEmployers.nameEmployerFrank;
            string getNameLocationExpected = getNameLocation.ToString();

            return getNameLocationExpected;
        }
    }
}
