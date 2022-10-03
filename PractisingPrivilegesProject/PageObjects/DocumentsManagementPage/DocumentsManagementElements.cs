using OpenQA.Selenium;
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
    }
}
