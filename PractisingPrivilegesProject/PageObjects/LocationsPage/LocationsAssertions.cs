﻿using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivileges.Helpers;
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

        [AllureStep("VerifyNewNameLocationMdlWndwAddNewLctnPg")]
        public Locations VerifyNewNameLocationMdlWndwAddNewLctnPg(string getNameLocationExpected)
        {
            WaitUntil.WaitSomeInterval(2000);
            string getNameLocationActual = Browser._Driver.FindElement(_NameLocationLctnsPg).Text;

            Assert.AreEqual(getNameLocationExpected, getNameLocationActual);

            return this;
        }
    }
}
