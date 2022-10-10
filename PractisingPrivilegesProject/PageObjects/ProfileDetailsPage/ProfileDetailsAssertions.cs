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
        [AllureStep("VerifyEnteredDataSelectedData")]
        public void VerifyEnteredDataSelectedData()
        {
            Assert.Multiple(() =>
            {
                Assert.IsTrue(Errors.IsInvisible(ErrorMessageYouMustEnterValuePrflPg));
                Assert.IsTrue(Errors.IsInvisible(ErrorMessagePleaseChooseSpecialtyLocationPrflPg));
            });
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
