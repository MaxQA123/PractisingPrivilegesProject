using NUnit.Allure.Attributes;
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
        [AllureStep("ClickButtonCreateNewUserUsersMngmntPg")]
        public UsersManagement ClickButtonCreateNewUserUsersMngmntPg()
        {
            Button.Click(ButtonCreateNewUserUsersMngmntPg);

            return this;
        }

        [AllureStep("ClickFieldInputSearchUsrsMngmntPg")]
        public UsersManagement ClickFieldInputSearchUsrsMngmntPg()
        {
            //Button.Click(FieldInputSearchUsrsMngmntPg);
            FieldInputSearchUsrsMngmntPg.Click();

            return this;
        }
    }
}
