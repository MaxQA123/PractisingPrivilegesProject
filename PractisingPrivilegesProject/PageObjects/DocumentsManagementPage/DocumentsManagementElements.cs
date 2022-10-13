using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.DocumentsManagementPage
{
    public partial class DocumentsManagement
    {
        [FindsBy(How = How.XPath, Using = "//h1[text() = 'Documents management']")]
        public IWebElement TitleDocumentsManagementDcmntsMngmntPg;

        #region Tabs

        [FindsBy(How = How.XPath, Using = "//div[@class= 'mat-tab-list']//div[@id = 'mat-tab-label-0-0']")]
        public IWebElement TabRolesDcmntsMngmntPg;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'mat-tab-list']//div[@id = 'mat-tab-label-0-1']")]
        public IWebElement TabDocumentsDcmntsMngmntPg;

        #endregion

        #region TabDocuments

        [FindsBy(How = How.XPath, Using = "//button[@class = 'mat-focus-indicator mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtonCreateNewDocumentDcmntsMngmntPg;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'mat-focus-indicator mat-flat-button mat-button-base mat-primary']")]
        public IWebElement ButtonCreateNewRoleDcmntsMngmntPg;

        #endregion

        [FindsBy(How = How.XPath, Using = "//div[contains(@aria-label, 'Test Documents 1 document successfully created')]")]
        public IWebElement MessageCreateNewDocumentDcmntsMngmntPg;

        [FindsBy(How = How.XPath, Using = "//div[contains(@aria-label, 'Role successfully created')]")]
        public IWebElement MessageRoleSuccessfullyCreatedDcmntsMngmntPg;

        [FindsBy(How = How.XPath, Using = "//table[@class = 'mat-table cdk-table custom']//tbody//tr[last()]")]
        public IWebElement NewCreatedRole;
    }
}
