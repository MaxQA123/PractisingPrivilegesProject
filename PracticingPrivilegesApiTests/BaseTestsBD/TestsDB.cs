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
        //This test case is doing checking: The name email had been got successfully.
        //Comment: 
        //Path to cheking's: 

        public void DisplayingUserEmail()
        {
            string test = WebSiteDBHelper.GetUserEmail();

            Console.WriteLine(test);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingBD")]
        [AllureSubSuite("GetNameDocumentFromBD")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The name role had been got successfully.
        //Comment: 
        //Path to cheking's: 

        public void DisplayingNameDocumentFromDB()
        {
            string nameDocumentFromDb = WebSiteDBHelper.GetNameDocument();

            Console.WriteLine(nameDocumentFromDb);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TestingBD")]
        [AllureSubSuite("GetNameRoleFromBD")]

        //Date of publication:
        //Version\Build:
        //Willingness for testing: Done.
        //This test case is doing checking: The name role had been got successfully.
        //Comment: 
        //Path to cheking's: 

        public void DisplayingNameRoleFromDB()
        {
            string nameRoleFromDb = WebSiteDBHelper.GetNameRole();

            Console.WriteLine(nameRoleFromDb);
        }
    }
}
