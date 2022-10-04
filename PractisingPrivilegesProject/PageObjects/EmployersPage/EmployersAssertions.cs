using NUnit.Allure.Attributes;
using NUnit.Framework;
using PractisingPrivileges.Helpers;
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

        [AllureStep("GetNameEmployerMdlWndwAddNewLctnPg")]
        public string GetNameEmployerMdlWndwAddNewLctnPg()
        {
            WaitUntil.WaitSomeInterval(500);
            string getNameLocation = Browser._Driver.FindElement(_NameEmployerLctnsPg).Text;
            string getNameLocationExpected = getNameLocation.ToString();

            return getNameLocationExpected;
        }

        //[AllureStep("VerifyNewNameLocationMdlWndwAddNewLctnPg")]
        //public Employers VerifyNewNameLocationMdlWndwAddNewLctnPg(string getNameLocationExpected)
        //{
        //    WaitUntil.WaitSomeInterval(2000);
        //    string getNameLocationActual = Browser._Driver.FindElement(_NameLocationLctnsPg).Text;

        //    Assert.AreEqual(getNameLocationActual, getNameLocationExpected);

        //    return this;
        //}
    }
}
