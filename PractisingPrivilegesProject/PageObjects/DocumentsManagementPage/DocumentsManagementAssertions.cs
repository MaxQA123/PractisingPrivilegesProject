using NUnit.Allure.Attributes;
using NUnit.Framework;
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
    }
}
