using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.SidebarPage
{
    public partial class Sidebar
    {
        [FindsBy(How = How.XPath, Using = "//img[@alt = 'user_management']")]
        public IWebElement ButtonUsersManagementSidebar;

        [FindsBy(How = How.XPath, Using = "//img[@alt = 'location']")]
        public IWebElement ButtonLocationSidebar;

        [FindsBy(How = How.XPath, Using = "//img[@alt = 'employer']")]
        public IWebElement ButtonEmployerSidebar;

        [FindsBy(How = How.XPath, Using = "//img[@alt = 'documents_management']")]
        public IWebElement ButtonDocumentsManagementSidebar;
    }
}
