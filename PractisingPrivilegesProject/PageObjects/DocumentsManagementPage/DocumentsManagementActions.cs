using NUnit.Allure.Attributes;
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
        [AllureStep("ClickTabDocumentsDcmntsMngmntPg")]
        public DocumentsManagement ClickTabDocumentsDcmntsMngmntPg()
        {
            Button.Click(TabDocumentsDcmntsMngmntPg);

            return this;
        }

        [AllureStep("ClickTabDocumentsDcmntsMngmntPg")]
        public DocumentsManagement ClickButtonCreateNewDocumentDcmntsMngmntPg()
        {
            Button.Click(ButtonCreateNewDocumentDcmntsMngmntPg);

            return this;
        }
    }
}
