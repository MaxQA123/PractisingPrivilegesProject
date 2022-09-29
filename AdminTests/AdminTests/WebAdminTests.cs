using AdminTests;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using PractisingPrivilegesProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdminTests
{
    [TestFixture]
    [AllureNUnit]
    public class WebSiteAdminTests : WebBaseAdmin
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("LogInAsSuperAdmin")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully SignUp as tenant.
        //Comment: 

        public void LogInAsSuperAdmin()
        {
            Pages.LogIn
                .SigningInAsSuperAdmin();

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleSuperAdmin(nameRoleCompare);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("LogInAsAdmin")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: in progress.
        //This test case is doing checking: The successfully SignUp as tenant.
        //Comment: 

        public void LogInAsAdmin()
        {
            Pages.LogIn
                .SigningInAsAdmin();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SuperAdminCreateClinician")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: in progress.
        //This test case is doing checking: The successfully SignUp as tenant.
        //Comment: 

        public void SuperAdminCreateClinician()
        {
            Pages.LogIn
                .SigningInAsSuperAdmin();

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleSuperAdmin(nameRoleCompare);
            Pages.UsersManagement
                .ClickButtonCreateNewUserUsersMngmntPg();
            Pages.ProfileDetails
                .OpenDropDownMenuSelectorRolesPrflPg()
                .SelectRoleClinicianViaDropDown()
                .SelectRoleViewerViaDropDown()
                .EnterFirstLastNameEmailPhonePrflPg()
                .SelectItemDrDropDownMenuTitlePrflPg()
                .SetGmcNumberPrflPg()
                .SetImcNumberPrflPg()
                .ClickButtonSpecialtyPrflPg();
            Pages.MdlWndwSelectSpecialties
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectSpecialties.urology, "")
                .ClickButtonAddMdlWndwSpecialtiesLocations();
            Pages.ProfileDetails
                .ClickButtonLocationPrflPg();
            Pages.MdlWndwSelectSpecialties
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectLocations.kphBelfast, "")
                .ClickButtonAddMdlWndwSpecialtiesLocations();
            Pages.ProfileDetails
                .ClickDropDownContactPrflPg()
                .SelectAdminContactDropDownPrflP(TestsDataForDropDownContactPrflPg.adminAdmin, "")
                .SelectConsultingTypePrivatePrflPg()
                .ScrollToButtonCreatePrflPg()
                .ClickDropDownCurrentEmployerPrflPg()
                .SelectCurrentEmployerDropDownPrflP(TestsDataForDropDownCurrentEmployerPrflPg.seTrust, "")
                .EnterDataJobTitleRestriction();

            Thread.Sleep(5000);
        }
    }
}
