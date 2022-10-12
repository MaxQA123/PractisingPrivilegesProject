using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.DocumentsManagementPage
{
    public partial class DocumentsManagement
    {
        [AllureStep("VerifyTitleDocumentsManagementPg")]
        public DocumentsManagement VerifyTitleDocumentsManagementPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleDocumentsManagementDcmntsMngmntPg));

            return this;
        }

        [AllureStep("VerifyCreatingNewDocument")]
        public DocumentsManagement VerifyCreatingNewDocument()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageCreateNewDocumentDcmntsMngmntPg));

            return this;
        }

        [AllureStep("VerifyCreatingNewRole")]
        public DocumentsManagement VerifyCreatingNewRole()
        {
            Assert.IsTrue(Successfully.IsVisible(MessageRoleSuccessfullyCreatedDcmntsMngmntPg));

            return this;
        }

        [AllureStep("VerifyDisplyingNameRoleOnPage")]
        public DocumentsManagement VerifyDisplyingNameRoleOnPage()
        {
            WaitUntil.WaitSomeInterval(1);
            string nameRoleActual = NewCreatedRole.Text;

            Assert.AreEqual(nameRoleActual, TestDataNameRoles.ROLE_TESTING);

            return this;
        }

    }
}
