using NUnit.Allure.Attributes;
using PractisingPrivilegesProject.Helpers;
using RimuTec.Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.ProfileDetailsPage
{
    public partial class ProfileDetails
    {
        #region DropDownMenuSelectorOfRoles

        [AllureStep("OpenDropDownMenuSelectorRolesPrflPg")]
        public ProfileDetails OpenDropDownMenuSelectorRolesPrflPg()
        {
            Button.Click(DropDownMenuSelectorRolesPrflPg);

            return this;
        }

        [AllureStep("SelectRoleClinicianViaDropDown")]
        public ProfileDetails SelectRoleClinicianViaDropDown()
        {
            Button.Click(CheckBoxClinicianPrflPg);

            return this;
        }

        [AllureStep("SelectRoleAdminViaDropDown")]
        public ProfileDetails SelectRoleAdminViaDropDown()
        {
            Button.Click(CheckBoxAdminPrflPg);

            return this;
        }

        [AllureStep("SelectRoleApproverViaDropDown")]
        public ProfileDetails SelectRoleApproverViaDropDown()
        {
            Button.Click(CheckBoxApproverPrflPg);

            return this;
        }

        [AllureStep("SelectRoleViewerViaDropDown")]
        public ProfileDetails SelectRoleViewerViaDropDown()
        {
            Button.Click(CheckBoxViewerPrflPg);

            return this;
        }

        #endregion

        #region MandatoryFildsToFillIn

        [AllureStep("EnterFirstLastNameEmailPhonePrflPg")]
        public ProfileDetails EnterFirstLastNameEmailPhonePrflPg()
        {
            Button.Click(FieldInputFirstNamePrflPg);
            InputGeneral.InputFunctionWithClear(FieldInputFirstNamePrflPg, Name.FirstName());
            InputGeneral.InputFunctionWithClear(FieldInputLastNamePrflPg, Name.LastName());
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressPrflPg, GenerateRandomDataHelper.RandomEmail(5) + TestDataEmailDomen.domenEmailXitroo);
            InputGeneral.InputFunctionWithClear(FieldInputContactTelephoneNumberPrflPg, GenerateRandomDataHelper.RandomPhoneNumber(10));

            return this;
        }

        [AllureStep("EnterConstFirstLastNameEmailPhonePrflPg")]
        public ProfileDetails EnterConstFirstLastNameEmailPhonePrflPg()
        {
            Button.Click(FieldInputFirstNamePrflPg);
            InputGeneral.InputFunctionWithClear(FieldInputFirstNamePrflPg, TestDataClinician.firstNameClinician);
            InputGeneral.InputFunctionWithClear(FieldInputLastNamePrflPg, TestDataClinician.lastNameClinician);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressPrflPg, GenerateRandomDataHelper.RandomEmail(5) + TestDataEmailDomen.domenEmailXitroo);
            InputGeneral.InputFunctionWithClear(FieldInputContactTelephoneNumberPrflPg, GenerateRandomDataHelper.RandomPhoneNumber(10));

            return this;
        }

        [AllureStep("EnterIdentificationNumberPrflPg")]
        public ProfileDetails EnterIdentificationNumberPrflPg()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstPersonalIdentificationNumberPrflPg, TestDataApprover.personalIdentificationNumber);
            InputGeneral.InputFunctionWithClear(FieldInputSecondPersonalIdentificationNumberPrflPg, TestDataApprover.personalIdentificationNumber);
            InputGeneral.InputFunctionWithClear(FieldInputThirdPersonalIdentificationNumberPrflPg, TestDataApprover.personalIdentificationNumber);
            InputGeneral.InputFunctionWithClear(FieldInputFourthPersonalIdentificationNumberPrflPg, TestDataApprover.personalIdentificationNumber);

            return this;
        }

        #endregion
    }
}
