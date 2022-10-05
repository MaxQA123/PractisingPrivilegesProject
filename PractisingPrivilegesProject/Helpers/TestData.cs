using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.Helpers
{
    public class EndPoints
    {
        public const string urlWebSite = "https://practicingprivileges.azurewebsites.net/auth/sign-in";
        public const string urlRandomEmail = "https://xitroo.com/";
        public const string urlConstEmail = "https://xitroo.com/#liludalastfg@xitroo.com";
        public const string urlConstEmailSuperAdminFrgtPsswrd = "https://xitroo.com/#eilhs@xitroo.com";
        public const string urlConstEmailAdminFrgtPsswrd = "https://xitroo.com/#eilhs@xitroo.com";
        public const string urlConstEmailClinicianFrgtPsswrd = "https://xitroo.com/#hungrydubinsky@xitroo.com";
        public const string urlConstEmailApproverFrgtPssword = "https://xitroo.com/#syeni@xitroo.com";
        public const string urlConstEmailViewerFrgtPssword = "https://xitroo.com/#kbfva@xitroo.com";

    }

    public class TestDataGeneral
    {
        public const string generalPassword = "Qwerty123!";
        public const string generalNewPassword = "!Qaz12345";
    }

    public class TestDataAdmin
    {
        public const string emailSuperAdmin = "super.admin@dev.com";
        public const string passwordSuperAdmin = "Jupiter1405!";

        public const string emailAdminQatester = "qatester91311@xitroo.com";
        public const string passwordNewAdminQatester = "!Qaz12345";

        public const string userNameRoleAdmin = "Admin Admin";
        public const string userNameRoleSuperAdmin = "Super Admin";

        public const string emailAdminForTestingFrgtPsswrd = "eilhs@xitroo.com";
        public const string passwordNewAdminForTestingFrgtPsswrd = "!Qaz12345";
    }

    public class TestDataClinician
    {
        public const string emailJaneClinician = "janeclinician-doe@xitroo.com";
        public const string userNameRoleJaneClinician = "JaneClinician Clinician";

        public const string firstNameClinician = "Clin";
        public const string lastNameClinician = "Clin";

        public const string emailClinicianForTestingFrgtPsswrd = "hungrydubinsky@xitroo.com";
        public const string passwordNewClinicianForTestingFrgtPsswrd = "!Qaz12345";
    }

    public class TestDataApprover
    {
        public const string emailJaneApprover = "jane-approver@xitroo.com";
        public const string userNameRoleApproverApprover = "Approver Approver";

        public const string firstNameApprover = "Test-Approver";
        public const string lastNameApprover = "Approver";
        public const string personalIdentificationNumber = "1";

        public const string emailApproverForTestingFrgtPsswrd = "syeni@xitroo.com";
        public const string passwordNewApproverForTestingFrgtPsswrd = "!Qaz12345";
    }

    public class TestDataViewer
    {
        public const string emailViewerViewer = "jane-viewer@xitroo.com";
        public const string userNameRoleViewerViewer = "Viewer Viewer";

        public const string firstNameViewer = "Test-Viewer";
        public const string lastNameViewer = "Viewer";

        public const string emailViewerForTestingFrgtPsswrd = "kbfva@xitroo.com";
        public const string passwordNewViewerForTestingFrgtPsswrd = "!Qaz12345";
    }

    public class TestDataNameDocumnets
    {
        public const string testing = "Test Documents 1";
        public const string testWithoutTime = "Test without time";
        public const string testEight = "Test Eight";
        public const string testSeven = "Test Seven";
        public const string testFifteen = "Test Fifteen";
        public const string newInfoTest = "New Info Test";

        public const string verifyInfoOnly = "Verify Info Only";
        public const string requiresRenewalOneTwoThree = "Requires Renewal One Two Three";
        public const string testingTestThreeHundred = "Testing Test Three Hundred";
        public const string visibleCheckedToViewersRequiresRenewal = "Visible Checked To Viewers RequiresRenewal";
        public const string withoutRequiresRenewal = "Without Requires Renewal";
        public const string termsAndConditions = "Terms and conditions";

        public const string termsAndConditionsSecond = "Terms and conditions second";
    }

    public class TestDataForRenewalTimeframe
    {
        public const string hours = "5";
        public const string days = "1";
        public const string months = "1";
        public const string years = "1";
    }

    public class TestDataForReminderTimeframe
    {
        public const string hours = "4";
        public const string days = "1";
        public const string months = "1";
        public const string years = "1";
    }

    public class TestDataReminderFrequency
    {
        public const string hours = "1";
        public const string days = "1";
        public const string months = "1";
    }

    public class TestDataEmailDomen
    {
        public const string domenEmailXitroo = "@xitroo.com";
        public const string PUTS_BOX = "@putsbox.com";
    }

    public class UploadImages
    {
        public const string avatarImgSuperAdmin = $"\\UploadImages\\SuperAdminAvatarTiger.jpg";
        public const string avatarImgAdmin = $"\\UploadImages\\AdminAvatar.jpg";
        public const string avatarImgClinician = $"\\UploadImages\\ClinicianAvatarIguanna.jpg";
        public const string avatarImgApprover = $"\\UploadImages\\ApproverAvatarDelphin.jpg";
        public const string avatarImgViewer = $"\\UploadImages\\ViewerAvatarPopugai.jpg";

        public const string pdfDocumentTestingOne = $"\\UploadImages\\TestingOne.pdf";
        public const string photoDocumentTestingTwo = $"\\UploadImages\\TestingTwo.jpg";
        public const string wordDocDocumentTestQA = $"\\UploadImages\\TestQA.doc";
        public const string wordDocxDocumentTextDocument = $"\\UploadImages\\TextDocument.docx";
        public const string pngDocumentRobot123 = $"\\UploadImages\\Robot123.png";
        public const string jpegDocumentDocument444 = $"\\UploadImages\\Document444.jpeg";
    }

}
