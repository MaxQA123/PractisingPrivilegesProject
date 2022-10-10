using AdminTests;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using PractisingPrivilegesProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PracticingPrivilegesApiTests.ApiPagesObjects;
using PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage;
using PutsboxWrapper;

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
        //This test case is doing checking: The successfully LogIn as super admin.
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
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully LogIn as admin.
        //Comment: 

        public void LogInAsAdmin()
        {
            Pages.LogIn
                .SigningInAsAdmin();

            var email = TestDataAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleAdmin(nameRoleCompare);

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
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been created a clinician.
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
                .EnterFirstLastNameEmailPhonePrflPg();

            string emailCopy = Pages.ProfileDetails.CopyEmailFromProfileDetails();

            Pages.ProfileDetails
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
                .EnterDataJobTitleRestriction()
                .ClickButtonCreatePrflPg()
                .VerifyEnteredDataSelectedData();
            Pages.Header
               .LoggedFromAccountOnHeader();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlRandomEmail);
            Pages.EmailXitroo
                .EnterEmail(emailCopy)
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickButtonConfirmEmailFromEmail();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningInNewUserAfterCreating(emailCopy);

            var responseLogIn = LogInApi.ExecuteLogIn(emailCopy, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);
            
            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("AdminCreateApprover")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been created a approver.
        //Comment: 

        public void AdminCreateApprover()
        {
            Pages.LogIn
                .SigningInAsAdmin();

            var email = TestDataAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleAdmin(nameRoleCompare);
            Pages.UsersManagement
                .ClickButtonCreateNewUserUsersMngmntPg();
            Pages.ProfileDetails
                .OpenDropDownMenuSelectorRolesPrflPg()
                .SelectRoleApproverViaDropDown()
                .SelectRoleViewerViaDropDown()
                .EnterFirstLastNameEmailPhonePrflPg();

                string emailCopy = Pages.ProfileDetails.CopyEmailFromProfileDetails();

            Pages.ProfileDetails
                .EnterPersonalIdentificationNumberPrflPg()
                .ClickButtonCreatePrflPg()
                .VerifyEnteredDataSelectedData();
                //.VerifyUserSuccessfullyCreatedPrflPg();
            Pages.Header
               .LoggedFromAccountOnHeader();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlRandomEmail);
            Pages.EmailXitroo
                .EnterEmail(emailCopy)
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickButtonConfirmEmailFromEmail();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningInNewUserAfterCreating(emailCopy);

            var approverResponseLogIn = LogInApi.ExecuteLogIn(emailCopy, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(approverResponseLogIn.code);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SuperAdminCreateAdmin")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been created a admin.
        //Comment: 

        public void SuperAdminCreateAdmin()
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
                .SelectRoleAdminViaDropDown()
                .SelectRoleViewerViaDropDown()
                .EnterFirstLastNameEmailPhonePrflPg();

            string emailCopy = Pages.ProfileDetails.CopyEmailFromProfileDetails();

            Pages.ProfileDetails
                .ClickButtonCreatePrflPg()
                .VerifyEnteredDataSelectedData();
            Pages.Header
               .LoggedFromAccountOnHeader();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlRandomEmail);
            Pages.EmailXitroo
                .EnterEmail(emailCopy)
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickButtonConfirmEmailFromEmail();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningInNewUserAfterCreating(emailCopy);

            var responseLogIn = LogInApi.ExecuteLogIn(emailCopy, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("AdminCreateViewer")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been created a viewer.
        //Comment: 

        public void AdminCreateViewer()
        {
            Pages.LogIn
                .SigningInAsAdmin();

            var email = TestDataAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleAdmin(nameRoleCompare);
            Pages.UsersManagement
                .ClickButtonCreateNewUserUsersMngmntPg();
            Pages.ProfileDetails
                .EnterFirstLastNameEmailPhonePrflPg();

            string emailCopy = Pages.ProfileDetails.CopyEmailFromProfileDetails();

            Pages.ProfileDetails
                .ClickButtonCreatePrflPg()
                .VerifyEnteredDataSelectedData();
            //.VerifyUserSuccessfullyCreatedPrflPg();
            Pages.Header
               .LoggedFromAccountOnHeader();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlRandomEmail);
            Pages.EmailXitroo
                .EnterEmail(emailCopy)
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickButtonConfirmEmailFromEmail();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningInNewUserAfterCreating(emailCopy);

            var approverResponseLogIn = LogInApi.ExecuteLogIn(emailCopy, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(approverResponseLogIn.code);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SuperAdminCreateUserWithAllRoles")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been created a user with all roles.
        //Comment: 

        public void SuperAdminCreateUserWithAllRoles()
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
                .SelectRoleAdminViaDropDown()
                .SelectRoleApproverViaDropDown()
                .CloseDropDownMenuSelectorRolesPrflPg()
                .EnterFirstLastNameEmailPhonePrflPg()
                .EnterPersonalIdentificationNumberPrflPg();

            string emailCopy = Pages.ProfileDetails.CopyEmailFromProfileDetails();

            Pages.ProfileDetails
                .SelectItemMrDropDownMenuTitlePrflPg()
                .SetGmcNumberPrflPg()
                .SetImcNumberPrflPg()
                .ClickButtonSpecialtyPrflPg();
            Pages.MdlWndwSelectSpecialties
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectSpecialties.urology, "")
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectSpecialties.ent, "")
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectSpecialties.ophthalmology, "")
                .ClickButtonAddMdlWndwSpecialtiesLocations();
            Pages.ProfileDetails
                .ClickButtonLocationPrflPg();
            Pages.MdlWndwSelectSpecialties
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectLocations.kphBelfast, "")
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectLocations.kingsbridgeSligo, "")
                .ClickButtonAddMdlWndwSpecialtiesLocations();
            Pages.ProfileDetails
                .ClickDropDownContactPrflPg()
                .SelectAdminContactDropDownPrflP(TestsDataForDropDownContactPrflPg.adminAdmin, "")
                .SelectConsultingTypePrivatePrflPg()
                .ScrollToButtonCreatePrflPg()
                .ClickDropDownCurrentEmployerPrflPg()
                .SelectCurrentEmployerDropDownPrflP(TestsDataForDropDownCurrentEmployerPrflPg.seTrust, "")
                .EnterDataJobTitleRestriction()
                .ClickButtonCreatePrflPg()
                .VerifyEnteredDataSelectedData();
            Pages.Header
               .LoggedFromAccountOnHeader();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlRandomEmail);
            Pages.EmailXitroo
                .EnterEmail(emailCopy)
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickButtonConfirmEmailFromEmail();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningInNewUserAfterCreating(emailCopy);

            var responseLogIn = LogInApi.ExecuteLogIn(emailCopy, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("AdminCreateUserClinicianApproverVieewer")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been created a user with roles clinician, approver and viewer.
        //Comment: 

        public void AdminCreateUserClinicianApproverVieewer()
        {
            Pages.LogIn
                .SigningInAsAdmin();

            var email = TestDataAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleAdmin(nameRoleCompare);
            Pages.UsersManagement
                .ClickButtonCreateNewUserUsersMngmntPg();
            Pages.ProfileDetails
                .OpenDropDownMenuSelectorRolesPrflPg()
                .SelectRoleApproverViaDropDown()
                .SelectRoleClinicianViaDropDown()
                .CloseDropDownMenuSelectorRolesPrflPg()
                .EnterFirstLastNameEmailPhonePrflPg();

            string emailCopy = Pages.ProfileDetails.CopyEmailFromProfileDetails();

            Pages.ProfileDetails
            //    .EnterPersonalIdentificationNumberPrflPg()
            //    .SelectItemProfDropDownMenuTitlePrflPg()
            //    .SetGmcNumberPrflPg()
            //    .SetImcNumberPrflPg()
            //    .ClickButtonSpecialtyPrflPg();
            //Pages.MdlWndwSelectSpecialties
            //    .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectSpecialties.urology, "")
            //    .ClickButtonAddMdlWndwSpecialtiesLocations();
            //Pages.ProfileDetails
            //    .ClickButtonLocationPrflPg();
            //Pages.MdlWndwSelectSpecialties
            //    .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectLocations.kphBelfast, "")
            //    .ClickButtonAddMdlWndwSpecialtiesLocations();
            //Pages.ProfileDetails
            //    .ClickDropDownContactPrflPg()
            //    .SelectAdminContactDropDownPrflP(TestsDataForDropDownContactPrflPg.adminAdmin, "")
            //    .SelectConsultingTypePrivatePrflPg()
            //    .ScrollToButtonCreatePrflPg()
            //    .ClickDropDownCurrentEmployerPrflPg()
            //    .SelectCurrentEmployerDropDownPrflP(TestsDataForDropDownCurrentEmployerPrflPg.seTrust, "")
            //    .EnterDataJobTitleRestriction()
                .ClickButtonCreatePrflPg()
                .VerifyEnteredDataSelectedData();
            //.VerifyUserSuccessfullyCreatedPrflPg();
            Pages.Header
               .LoggedFromAccountOnHeader();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlRandomEmail);
            Pages.EmailXitroo
                .EnterEmail(emailCopy)
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickButtonConfirmEmailFromEmail();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningInNewUserAfterCreating(emailCopy);

            var approverResponseLogIn = LogInApi.ExecuteLogIn(emailCopy, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(approverResponseLogIn.code);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SuperAdminCreateUserClinicianViewer")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been created a user with roles clinician, viewer.
        //Comment: 

        public void SuperAdminCreateUserClinicianViewer()
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
                .CloseDropDownMenuSelectorRolesPrflPg()
                .EnterFirstLastNameEmailPhonePrflPg();

            string emailCopy = Pages.ProfileDetails.CopyEmailFromProfileDetails();

            Pages.ProfileDetails
                .SelectItemMrDropDownMenuTitlePrflPg()
                .SetGmcNumberPrflPg()
                .SetImcNumberPrflPg()
                .ClickButtonSpecialtyPrflPg();
            Pages.MdlWndwSelectSpecialties
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectSpecialties.urology, "")
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectSpecialties.ent, "")
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectSpecialties.ophthalmology, "")
                .ClickButtonAddMdlWndwSpecialtiesLocations();
            Pages.ProfileDetails
                .ClickButtonLocationPrflPg();
            Pages.MdlWndwSelectSpecialties
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectLocations.kphBelfast, "")
                .SelectItemSpecialtiesMdlWndw(TestsDataForMdlWndwSelectLocations.kingsbridgeSligo, "")
                .ClickButtonAddMdlWndwSpecialtiesLocations();
            Pages.ProfileDetails
                .ClickDropDownContactPrflPg()
                .SelectAdminContactDropDownPrflP(TestsDataForDropDownContactPrflPg.adminAdmin, "")
                .SelectConsultingTypePrivatePrflPg()
                .ScrollToButtonCreatePrflPg()
                .ClickDropDownCurrentEmployerPrflPg()
                .SelectCurrentEmployerDropDownPrflP(TestsDataForDropDownCurrentEmployerPrflPg.seTrust, "")
                .EnterDataJobTitleRestriction()
                .ClickButtonCreatePrflPg()
                .VerifyEnteredDataSelectedData();
            Pages.Header
               .LoggedFromAccountOnHeader();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlRandomEmail);
            Pages.EmailXitroo
                .EnterEmail(emailCopy)
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickButtonConfirmEmailFromEmail();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningInNewUserAfterCreating(emailCopy);

            var responseLogIn = LogInApi.ExecuteLogIn(emailCopy, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("AdminCreateApproverViewer")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been created a approver, viewer.
        //Comment: 

        public void AdminCreateApproverViewer()
        {
            Pages.LogIn
                .SigningInAsAdmin();

            var email = TestDataAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleAdmin(nameRoleCompare);
            Pages.UsersManagement
                .ClickButtonCreateNewUserUsersMngmntPg();
            Pages.ProfileDetails
                .OpenDropDownMenuSelectorRolesPrflPg()
                .SelectRoleApproverViaDropDown()
                .CloseDropDownMenuSelectorRolesPrflPg()
                .EnterFirstLastNameEmailPhonePrflPg();

            string emailCopy = Pages.ProfileDetails.CopyEmailFromProfileDetails();

            Pages.ProfileDetails
                .EnterPersonalIdentificationNumberPrflPg()
                .ClickButtonCreatePrflPg()
                .VerifyEnteredDataSelectedData();
            //.VerifyUserSuccessfullyCreatedPrflPg();
            Pages.Header
               .LoggedFromAccountOnHeader();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlRandomEmail);
            Pages.EmailXitroo
                .EnterEmail(emailCopy)
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickButtonConfirmEmailFromEmail();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningInNewUserAfterCreating(emailCopy);

            var approverResponseLogIn = LogInApi.ExecuteLogIn(emailCopy, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(approverResponseLogIn.code);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SuperAdminCreateUserApproverClinician")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been created a clinician.
        //Comment: 

        public void SuperAdminCreateUserApproverClinician()
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
                .SelectRoleApproverViaDropDown()
                .SelectRoleViewerViaDropDown()
                .EnterFirstLastNameEmailPhonePrflPg();

            string emailCopy = Pages.ProfileDetails.CopyEmailFromProfileDetails();

            Pages.ProfileDetails
                .EnterPersonalIdentificationNumberPrflPg()
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
                .EnterDataJobTitleRestriction()
                .ClickButtonCreatePrflPg()
                .VerifyEnteredDataSelectedData();
            Pages.Header
               .LoggedFromAccountOnHeader();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlRandomEmail);
            Pages.EmailXitroo
                .EnterEmail(emailCopy)
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickButtonConfirmEmailFromEmail();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningInNewUserAfterCreating(emailCopy);

            var responseLogIn = LogInApi.ExecuteLogIn(emailCopy, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("SuperAdminForgotPassword")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: in progress.
        //This test case is doing checking: The successfully had been changed a password for super admin.
        //Comment: 

        public void SuperAdminForgotPassword()
        {

        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("AdminForgotPassword")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been changed a password for admin.
        //Comment: 

        public void AdminForgotPassword()
        {
            Pages.LogIn
                .ClickLinkForgotPasswordLogInPg();
            Pages.ForgotPassword
                .VerifyTitleForgotPasswordPg()
                .EnterEmailOnFrgtPsswrdPg();
            Pages.ForgotPassword
                .ClickButtonRequestOKFrgtPsswrdPg();
            Pages.SwitchingJScriptExecutorHelper
                .OpenNewTab();
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlConstEmailAdminFrgtPsswrd);
            Pages.EmailXitroo
                .EnterEmail()
                .ClickSearchButton()
                .OpenNewlyLetter()
                .ClickLinkResetPassword();
            Pages.SetPassword
                .EnterPasswordRepeatPassword()
                .ClickButtonSetPassworSetPassworddPg()
                .VerifyMessageChangePasswordSetPasswordPg();
            Pages.LogIn
                .SigningAfterChangingPassword();

            var email = TestDataAdmin.emailAdminForTestingFrgtPsswrd;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataAdmin.passwordNewAdminForTestingFrgtPsswrd);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("VerifySidebar")]

        public void VerifySidebar()
        {
            Pages.LogIn
                .SigningInAsAdmin();

            var email = TestDataAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);
            Pages.Sidebar
                .ClickButtonLocationSidebar();
            Pages.Locations
                .VerifyTitleLocationstPg();
            Pages.Sidebar
                .ClickButtonEmployerSidebar();
            Pages.Employers
                .VerifyTitleEmployersPg();
            Pages.Sidebar
                .ClickButtonDocumentsManagementSidebar();
            Pages.DocumentsManagement
                .VerifyTitleDocumentsManagementPg();
            Pages.Sidebar
                .ClickButtonUsersManagementSidebar();
            Pages.UsersManagement
                .VerifyTitleUsersManagmentPg();

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("AddNewLocationAsSuperAdmin")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully had been added a new location.
        //Comment: 

        public void AddNewLocationAsSuperAdmin()
        {
            Pages.LogIn
                .SigningInAsSuperAdmin();

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleSuperAdmin(nameRoleCompare);
            Pages.Sidebar
                .ClickButtonLocationSidebar();
            Pages.Locations
                .VerifyTitleLocationstPg()
                .ClickButtonAddNewLocationLctnsPg();
            Pages.MdlWndwAddNewLocation
                .EnterNameLocationMdlWndwAddNewLctn();

            string getNameForCompare = Pages.MdlWndwAddNewLocation.GetNameLocationMdlWndwAddNewLctnPg();

            Pages.MdlWndwAddNewLocation
                .ClickDropDownAddClinicianMdlWndwAddNewLctnPg()
                .SelectClinicianMdlWndwAddNewLctn(TestDataForDropDownAddClinicianForLocation.janeClinician, "")
                .ClickFieldInputNameLocationMdlWndwAddNewLctnPg()
                .ClickDropDownAddClinicianMdlWndwAddNewLctnPg()
                .SelectClinicianMdlWndwAddNewLctn(TestDataForDropDownAddClinicianForLocation.nextWithTopOfListOne, "")
                .ClickFieldInputNameLocationMdlWndwAddNewLctnPg()
                .ClickDropDownAddClinicianMdlWndwAddNewLctnPg()
                .SelectClinicianMdlWndwAddNewLctn(TestDataForDropDownAddClinicianForLocation.nextWithTopOfListOne, "")
                .ClickButtonAddMdlWndwAddNewLctnPg()
                .VerifyMessageLocationCreatedMdlWndwAddNewLctnPg();
            Pages.SelectorNumberPagesForAllPages
                .ClickDropDownSelectorNumber()
                .SelectNumberPage(TestDataForDropDownNumberPage.oneHundredItem, "");
            Pages.Locations
                .VerifyNewNameLocationMdlWndwAddNewLctnPg(getNameForCompare);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("AddNewEmployerAsAdmin")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has been created a new employer.
        //Comment: 

        public void AddNewEmployerAsAdmin()
        {
            Pages.LogIn
                .SigningInAsAdmin();

            var email = TestDataAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleAdmin(nameRoleCompare);
            Pages.Sidebar
                .ClickButtonEmployerSidebar();
            Pages.Employers
                .VerifyTitleEmployersPg()
                .ClickButtonAddNewEmployerEmplrsPg();
            Pages.MdlWndwAddNewEmployer
                .EnterNameEmployerMdlWndwAddNewEmplr();

            string getNameForCompare = Pages.MdlWndwAddNewEmployer.GetNameEmployerMdlWndwAddNewEmplrPg();

            Pages.MdlWndwAddNewEmployer
                .ClickDropDownAddClinicianMdlWndwAddNewEmplrPg()
                .SelectClinicianMdlWndwAddNewEmplr(TestDataForDropDownAddClinicianForEnployer.janeClinician, "")
                .ClickFieldInputNameEmployerMdlWndwAddNewEmplrPg()
                .ClickDropDownAddClinicianMdlWndwAddNewEmplrPg()
                .SelectClinicianMdlWndwAddNewEmplr(TestDataForDropDownAddClinicianForEnployer.janeClinician, "")
                .ClickFieldInputNameEmployerMdlWndwAddNewEmplrPg()
                .ClickDropDownAddClinicianMdlWndwAddNewEmplrPg()
                .SelectClinicianMdlWndwAddNewEmplr(TestDataForDropDownAddClinicianForEnployer.nextWithTopOfListOne, "")
                .ClickButtonAddMdlWndwAddNewEmplrPg()
                .VerifyMessageEmployerCreatedMdlWndwAddNewEmplrPg();
            Pages.Locations
                .VerifyNewNameLocationMdlWndwAddNewLctnPg(getNameForCompare);

            Thread.Sleep(5000);
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Admin")]
        [AllureSubSuite("AddNewDocWithoutRequiresRenewal")]

        //Date of publication:
        //Version\Build:
        //The date last publication on which been testing:
        //Willingness for testing: Done.
        //This test case is doing checking: The successfully has been created a new dociment without "Requires Renewal".
        //Comment: 

        public void AddNewDocWithoutRequiresRenewal()
        {
            Pages.LogIn
               .SigningInAsAdmin();

            var email = TestDataAdmin.emailAdminQatester;

            var responseLogIn = LogInApi.ExecuteLogIn(email, TestDataGeneral.generalPassword);

            Pages.VerificationCode
                .ConfirmVerificationCode(responseLogIn.code);

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleAdmin(nameRoleCompare);
            Pages.Sidebar
                .ClickButtonDocumentsManagementSidebar();
            Pages.DocumentsManagement
                .VerifyTitleDocumentsManagementPg()
                .ClickTabDocumentsDcmntsMngmntPg()
                .ClickButtonCreateNewDocumentDcmntsMngmntPg();
            Pages.MdlWndwAddNewDocuments
                .EnterFieldInputNameMdlWndwAddNewDocs()
                .SelectAllFormatFilesMdlWndwAddNewDocs()
                .ClickCheckBoxRenewalRequiredMdlWndwAddNewDocs()
                .EnterRenewalTimeFramMdlWndwAddNewDocs()
                .EnterReminderTimeFramMdlWndwAddNewDocs()
                .SetEveryHoursReminderFrequency()
                .UploadDocuments()
                .VerifyEnterData()
                .VerifyUploadedFilesRemove()
                .ClickButtonAddMdlWndwAddNewDocs();
            Pages.DocumentsManagement
                .VerifyCreatingNewDocument();

            Thread.Sleep(5000);
        }
        
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Demo")]
        [AllureSubSuite("Demo")]

        public void Demo()
        {
            Pages.LogIn
            .SigningInAsSuperAdmin();

            string nameRoleCompare = Pages.Header.GetNameRoleFromHeader();

            Pages.Header
                .VerifyNameRoleSuperAdmin(nameRoleCompare);

            Thread.Sleep(5000);
        }
    }
}
