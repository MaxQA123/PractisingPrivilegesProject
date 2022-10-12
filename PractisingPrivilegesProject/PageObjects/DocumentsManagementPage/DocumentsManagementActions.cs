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

        [AllureStep("ClickTabRolesDcmntsMngmntPg")]
        public DocumentsManagement ClickTabRolesDcmntsMngmntPg()
        {
            Button.Click(TabRolesDcmntsMngmntPg);

            return this;
        }

        [AllureStep("ClickButtonCreateNewRoleDcmntsMngmntPg")]
        public DocumentsManagement ClickButtonCreateNewRoleDcmntsMngmntPg()
        {
            Button.Click(ButtonCreateNewRoleDcmntsMngmntPg);

            return this;
        }

        [AllureStep("ClickButtonCreateNewDocumentDcmntsMngmntPg")]
        public DocumentsManagement ClickButtonCreateNewDocumentDcmntsMngmntPg()
        {
            Button.Click(ButtonCreateNewDocumentDcmntsMngmntPg);

            return this;
        }
    }
}
