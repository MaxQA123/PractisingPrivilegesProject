using PractisingPrivileges.Helpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
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
        [AllureStep("GetNameRoleFromHeader")]
        public string GetNameRoleFromHeader()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getNameRole = Browser._Driver.FindElement(_TextNameRoleOnHeader).Text;
            string getNameRoleActual = getNameRole.ToString();

            return getNameRoleActual;
        }

        [AllureStep("VerifyNameRoleSuperAdmin")]
        public Header VerifyNameRoleSuperAdmin(string getNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(2000);
            string nameRoleExpected = TestDataAdmin.userNameRoleSuperAdmin;

            Assert.AreEqual(nameRoleExpected, getNameRoleActual);

            return this;
        }

        [AllureStep("VerifyNameRoleAdmin")]
        public Header VerifyNameRoleAdmin(string getNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(2000);
            string nameRoleExpected = TestDataAdmin.userNameRoleAdmin;

            Assert.AreEqual(nameRoleExpected, getNameRoleActual);

            return this;
        }

        [AllureStep("VerifyNameRoleClinician")]
        public Header VerifyNameRoleClinician(string getNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(2000);
            string nameRoleExpected = TestDataClinician.userNameRoleJaneClinician;

            Assert.AreEqual(nameRoleExpected, getNameRoleActual);

            return this;
        }

        [AllureStep("VerifyNameRoleApprover")]
        public Header VerifyNameRoleApprover(string getNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(2000);
            string nameRoleExpected = TestDataApprover.userNameRoleApproverApprover;

            Assert.AreEqual(nameRoleExpected, getNameRoleActual);

            return this;
        }

        [AllureStep("VerifyNameRoleViewer")]
        public Header VerifyNameRoleViewer(string getNameRoleActual)
        {
            WaitUntil.WaitSomeInterval(2000);
            string nameRoleExpected = TestDataViewer.userNameRoleViewerViewer;

            Assert.AreEqual(nameRoleExpected, getNameRoleActual);

            return this;
        }
    }
}
