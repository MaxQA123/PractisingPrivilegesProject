using NUnit.Allure.Attributes;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.LocationsPage
{
    public partial class Locations
    {
        [AllureStep("ClickButtonAddNewLocationLctnsPg")]
        public Locations ClickButtonAddNewLocationLctnsPg()
        {
            Button.Click(ButtonAddNewLocationLctnsPg);

            return this;
        }
    }
}
