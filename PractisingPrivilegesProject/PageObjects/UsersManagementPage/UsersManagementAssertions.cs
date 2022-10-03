using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.UsersManagementPage
{
    public partial class UsersManagement
    {
        [AllureStep("VerifyTitleUsersManagmentPg")]
        public UsersManagement VerifyTitleUsersManagmentPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleUsersManagmentUsrsMngmntPg));

            return this;
        }
    }
}
