using CazamioProgect.Helpers;
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
            WaitUntil.WaitSomeInterval(1);
            string nameRoleExpected = TestDataAdmin.userNameRoleSuperAdmin;

            Assert.AreEqual(nameRoleExpected, getNameRoleActual);

            return this;
        }

    }
}
