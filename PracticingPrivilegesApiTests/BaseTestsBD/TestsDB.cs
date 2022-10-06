using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.BaseTestsBD
{
    [TestFixture]
    [AllureNUnit]

    public class TestsDB
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingBD")]
        [AllureSubSuite("GetUserEmailFromBD")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn.
        //Comment: 
        //Path to cheking's: 

        public void GetUserEmailFromBD()
        {
            string test = WebSiteDBHelper.GetUserEmail();

            Console.WriteLine(test);
        }
    }
}
