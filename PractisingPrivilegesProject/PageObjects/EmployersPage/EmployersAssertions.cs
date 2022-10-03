using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.EmployersPage
{
    public partial class Employers
    {
        [AllureStep("VerifyTitleEmployersPg")]
        public Employers VerifyTitleEmployersPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleEmployersEmplrsPg));

            return this;
        }
    }
}
