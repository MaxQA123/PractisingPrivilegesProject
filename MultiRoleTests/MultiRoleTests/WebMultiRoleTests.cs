﻿using Allure.Commons;
using MultiRoleTests;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiRoleTests
{
    [TestFixture]
    [AllureNUnit]

    public class WebMultiRoleTests : WebBaseMultiRole
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MultiRole")]
        [AllureSubSuite("CreateNewUserWithAllRoles")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: in progress.
        //This test case is doing checking: The successfully SignUp as tenant.
        //Comment: Bug: on email hasn't came a letter for confirming.

        public void CreateNewUserWithAllRoles()
        {

        }
    }
}
