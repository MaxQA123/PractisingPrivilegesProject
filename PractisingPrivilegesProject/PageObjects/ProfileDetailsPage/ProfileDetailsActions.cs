using NUnit.Allure.Attributes;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.ProfileDetailsPage
{
    public partial class ProfileDetails
    {
        [AllureStep("OpenDropDownMenuSelectorRolesPrflPg")]
        public ProfileDetails OpenDropDownMenuSelectorRolesPrflPg()
        {
            Button.Click(DropDownMenuSelectorRolesPrflPg);

            return this;
        }
    }
}
