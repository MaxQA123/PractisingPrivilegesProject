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

        [AllureStep("VerifyFirstNameClinician")]
        public Header VerifyFirstNameClinician(string firstNameActual)
        {
            WaitUntil.WaitSomeInterval(2000);
            string nameRoleExpected = TestDataClinician.userNameRoleJaneClinician;

            Assert.AreEqual(nameRoleExpected, firstNameActual);

            return this;
        }

        [AllureStep("VerifyFirstLastNameRandom")]
        public Header VerifyFirstLastNameRandom(string firstNameExpected, string firstNameActual, string lastNameExpected, string lastNameActual)
        {
            WaitUntil.WaitSomeInterval(500);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(lastNameExpected, lastNameActual);
                Assert.AreEqual(firstNameExpected, firstNameActual);

                Console.WriteLine($"First name expected: {firstNameExpected}");
                Console.WriteLine($"First name actual: {firstNameActual}");

                Console.WriteLine($"Last name expected: {lastNameExpected}");
                Console.WriteLine($"Last name actual: {lastNameActual}");
                
            });

            return this;

        }

        [AllureStep("VerifyNameRoleApprover")]
        public Header VerifyNameRoleApprover(string getFirstNameActual)
        {
            WaitUntil.WaitSomeInterval(2000);
            string nameRoleExpected = TestDataApprover.userNameRoleApproverApprover;

            Assert.AreEqual(nameRoleExpected, getFirstNameActual);

            return this;
        }

        [AllureStep("VerifyNameRoleViewer")]
        public Header VerifyNameRoleViewer(string getFirstNameActual)
        {
            WaitUntil.WaitSomeInterval(2000);
            string nameRoleExpected = TestDataViewer.userNameRoleViewerViewer;

            Assert.AreEqual(nameRoleExpected, getFirstNameActual);

            return this;
        }
    }
}
