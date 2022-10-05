using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewDocumentsPage
{
    public partial class MdlWndwAddNewDocuments
    {
        [AllureStep("VerifyEnterData")]
        public MdlWndwAddNewDocuments VerifyEnterData()
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.IsTrue(Errors.IsInvisible(ErrorMessageYouMustEnterValueMdlWndwAddNewDocs));

            return this;
        }

        [AllureStep("VerifyUploadedFilesInvalid")]
        public MdlWndwAddNewDocuments VerifyUploadedFilesInvalid()
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.IsTrue(Errors.IsInvisible(ErrorMessageThisFileInvalidMdlWndwAddNewDocs));

            return this;
        }

        [AllureStep("VerifyUploadedFilesRemove")]
        public MdlWndwAddNewDocuments VerifyUploadedFilesRemove()
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.IsTrue(Errors.IsInvisible(ErrorMessagePleaseRemoveInvalidFilesMdlWndwAddNewDocs));

            return this;
        }
    }
}
