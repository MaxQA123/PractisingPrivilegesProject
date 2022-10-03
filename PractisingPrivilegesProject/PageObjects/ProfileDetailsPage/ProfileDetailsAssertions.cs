using NUnit.Allure.Attributes;
using NUnit.Framework;
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
        [AllureStep("VerifyEnterData")]
        public ProfileDetails VerifyEnterData()
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.IsTrue(Errors.IsInvisible(ErrorMessageYouMustEnterValuePrflPg));

            return this;
        }

        [AllureStep("VerifySelectData")]
        public ProfileDetails VerifySelectData()
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.IsTrue(Errors.IsInvisible(ErrorMessagePleaseChooseSpecialtyLocationPrflPg));
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }

        [AllureStep("VerifyUserSuccessfullyCreatedPrflPg")]
        public ProfileDetails VerifyUserSuccessfullyCreatedPrflPg()
        {
            WaitUntil.CustomElementIsVisible(SuccessfullyMessageUserSuccessfullyCreatedPrflPg);
            Assert.IsTrue(Successfully.IsVisible(SuccessfullyMessageUserSuccessfullyCreatedPrflPg));
            WaitUntil.WaitSomeInterval(3000);

            return this;
        }
    }
}
