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

        //[AllureStep("VerifyCreatingNewDocument")]
        //public DocumentsManagement VerifyCreatingNewDocument()
        //{
        //    Assert.IsTrue(Successfully.IsVisible(MessageCreateNewDocumentDcmntsMngmntPg));

        //    return this;
        //}

        [AllureStep("VerifyCreatingNewDocument")]
        public void VerifyCreatingNewDocument()
        {
            Assert.Multiple(() =>
            {
                WaitUntil.WaitSomeInterval(500);
                Assert.IsTrue(Successfully.IsVisible(MessageCreateNewDocumentDcmntsMngmntPg));

                string nameDocumentFromDbActual = WebSiteDBHelper.GetNameDocument();
                Assert.AreEqual(nameDocumentFromDbActual, TestDataNameDocumnets.testing);
                Console.WriteLine($"Created document:{nameDocumentFromDbActual}");
            });
        }

        [AllureStep("VerifyCreatingNewRole")]
        public void VerifyCreatingNewRole()
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(Successfully.IsVisible(MessageRoleSuccessfullyCreatedDcmntsMngmntPg));

                string nameRoleFromDbActual = WebSiteDBHelper.GetNameRole();
                Assert.AreEqual(nameRoleFromDbActual, TestDataNameRoles.ROLE_TESTING);
                Console.WriteLine($"Created role:{nameRoleFromDbActual}");
            });
        }
    }
}
