using NUnit.Allure.Attributes;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.SidebarPage
{
    public partial class Sidebar
    {
        [AllureStep("ClickButtonUsersManagementSidebar")]
        public Sidebar ClickButtonUsersManagementSidebar()
        {
            Button.Click(ButtonUsersManagementSidebar);

            return this;
        }

        [AllureStep("ClickButtonLocationSidebar")]
        public Sidebar ClickButtonLocationSidebar()
        {
            Button.Click(ButtonLocationSidebar);

            return this;
        }

        [AllureStep("ClickButtonEmployerSidebar")]
        public Sidebar ClickButtonEmployerSidebar()
        {
            Button.Click(ButtonEmployerSidebar);

            return this;
        }

        [AllureStep("ClickButtonDocumentsManagementSidebar")]
        public Sidebar ClickButtonDocumentsManagementSidebar()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonDocumentsManagementSidebar);

            return this;
        }
    }
}
