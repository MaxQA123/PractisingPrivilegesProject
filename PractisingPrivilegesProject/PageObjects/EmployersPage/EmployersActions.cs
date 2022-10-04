using NUnit.Allure.Attributes;
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
        [AllureStep("ClickButtonAddNewEmployerEmplrsPg")]
        public Employers ClickButtonAddNewEmployerEmplrsPg()
        {
            Button.Click(ButtonAddNewEmployerEmplrsPg);

            return this;
        }
    }
}
