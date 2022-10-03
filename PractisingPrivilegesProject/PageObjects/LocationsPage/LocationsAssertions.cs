using NUnit.Allure.Attributes;
using NUnit.Framework;
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
        [AllureStep("VerifyTitleLocationstPg")]
        public Locations VerifyTitleLocationstPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleLocationsLctnsPg));

            return this;
        }
    }
}
