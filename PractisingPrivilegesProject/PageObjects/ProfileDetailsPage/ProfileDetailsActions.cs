using PractisingPrivileges.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
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
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(AllPageProfileDetails);

            return this;
        }

        #endregion

        #region MandatoryFildsToFillIn

        [AllureStep("EnterFirstLastNameEmailPhonePrflPg")]
        public ProfileDetails EnterFirstLastNameEmailPhonePrflPg()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputFirstNamePrflPg, Name.FirstName());
            InputGeneral.InputFunctionWithClear(FieldInputLastNamePrflPg, Name.LastName());
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressPrflPg, GenerateRandomDataHelper.RandomEmail(5) + TestDataEmailDomen.domenEmailXitroo);
            InputGeneral.InputFunctionWithClear(FieldInputContactTelephoneNumberPrflPg, GenerateRandomDataHelper.RandomPhoneNumber(10));

            return this;
        }

        [AllureStep("EnterConstFirstLastNameEmailPhonePrflPg")]
        public ProfileDetails EnterConstFirstLastNameEmailPhonePrflPg()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputFirstNamePrflPg, TestDataClinician.firstNameClinician);
            InputGeneral.InputFunctionWithClear(FieldInputLastNamePrflPg, TestDataClinician.lastNameClinician);
            InputGeneral.InputFunctionWithClear(FieldInputEmailAddressPrflPg, GenerateRandomDataHelper.RandomEmail(5) + TestDataEmailDomen.domenEmailXitroo);
            InputGeneral.InputFunctionWithClear(FieldInputContactTelephoneNumberPrflPg, GenerateRandomDataHelper.RandomPhoneNumber(10));

            return this;
        }

        [AllureStep("EnterIdentificationNumberPrflPg")]
        public ProfileDetails EnterIdentificationNumberPrflPg()
        {
            WaitUntil.WaitSomeInterval(500);
            InputGeneral.InputFunctionWithClear(FieldInputFirstPersonalIdentificationNumberPrflPg, TestDataApprover.personalIdentificationNumber);
            InputGeneral.InputFunctionWithClear(FieldInputSecondPersonalIdentificationNumberPrflPg, TestDataApprover.personalIdentificationNumber);
            InputGeneral.InputFunctionWithClear(FieldInputThirdPersonalIdentificationNumberPrflPg, TestDataApprover.personalIdentificationNumber);
            InputGeneral.InputFunctionWithClear(FieldInputFourthPersonalIdentificationNumberPrflPg, TestDataApprover.personalIdentificationNumber);

            return this;
        }

        #endregion

        #region DropDownMenuSelectorOfTitle

        [AllureStep("OpenDropDownMenuTitlePrflPg")]
        public ProfileDetails SelectItemDrDropDownMenuTitlePrflPg()
        {
            Button.Click(DropDownMenuSelectorTitlePrflPg);
            Button.Click(ItemDrPrflPg);

            return this;
        }

        [AllureStep("OpenDropDownMenuTitlePrflPg")]
        public ProfileDetails SelectItemMrDropDownMenuTitlePrflPg()
        {
            Button.Click(DropDownMenuSelectorTitlePrflPg);
            Button.Click(ItemMrPrflPg);

            return this;
        }

        [AllureStep("SelectItemProfDropDownMenuTitlePrflPg")]
        public ProfileDetails SelectItemProfDropDownMenuTitlePrflPg()
        {
            Button.Click(DropDownMenuSelectorTitlePrflPg);
            Button.Click(ItemProfPrflPg);

            return this;
        }

        #endregion

        #region SetGMCandIMC

        [AllureStep("SetGmcNumberPrflPg")]
        public ProfileDetails SetGmcNumberPrflPg()
        {
            InputGeneral.InputFunctionWithClear(FieldInputGmcPrflPg, GenerateRandomDataHelper.RandomGmcNumber(7));
            Button.Click(IconForSaveGmcPrflPg);

            return this;
        }

        [AllureStep("SetImcNumberPrflPg")]
        public ProfileDetails SetImcNumberPrflPg()
        {
            InputGeneral.InputFunctionWithClear(FieldInputImcPrflPg, GenerateRandomDataHelper.RandomImcNumber(7));
            Button.Click(IconForSaveImcPrflPg);

            return this;
        }

        #endregion

        [AllureStep("ClickButtonSpecialtyPrflPg")]
        public ProfileDetails ClickButtonSpecialtyPrflPg()
        {
            Button.Click(ButtonSpecialtyPrflPg);

            return this;
        }

        [AllureStep("ClickButtonLocationPrflPg")]
        public ProfileDetails ClickButtonLocationPrflPg()
        {
            Button.Click(ButtonLocationPrflPg);

            return this;
        }

        #region DropDownMenuSelectorOfContact

        [AllureStep("ClickDropDownContactPrflPg")]
        public ProfileDetails ClickDropDownContactPrflPg()
        {
            Button.Click(DropDownSelectorContactPrflPg);

            return this;
        }

        private static IWebElement _element;

        [AllureStep("SelectorItemLocationsMdlWndw")]
        public static IList<IWebElement> SelectorAdminContactDropDownPrflPg(string _locationItem)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@role = 'listbox']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//span[contains(text(), '{_locationItem}')]"));
        }

        [AllureStep("SelectItemLocationsMdlWndw")]
        public ProfileDetails SelectAdminContactDropDownPrflP(int item, string locationItem)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _item = SelectorAdminContactDropDownPrflPg(locationItem);

            _item[item].Click();

            return this;
        }

        #endregion

        #region DropDownMenuSelectorOfConsultingType

        [AllureStep("SelectConsultingTypeBothPrflPg")]
        public ProfileDetails SelectConsultingTypeBothPrflPg()
        {
            Button.Click(DropDownMenuSelectorConsultingTypePrflPg);
            Button.Click(ItemBothPrflPg);

            return this;
        }

        [AllureStep("SelectConsultingTypePrivatePrflPg")]
        public ProfileDetails SelectConsultingTypePrivatePrflPg()
        {
            Button.Click(DropDownMenuSelectorConsultingTypePrflPg);
            Button.Click(ItemPrivatePrflPg);

            return this;
        }

        [AllureStep("SelectConsultingTypeWliPrflPg")]
        public ProfileDetails SelectConsultingTypeWliPrflPg()
        {
            Button.Click(DropDownMenuSelectorConsultingTypePrflPg);
            Button.Click(ItemWliPrflPg);

            return this;
        }

        #endregion

        [AllureStep("ScrollToButtonCreatePrflPg")]
        public ProfileDetails ScrollToButtonCreatePrflPg()
        {
            WaitUntil.WaitSomeInterval(500);
            ScrollingJScriptExecutorHelper.ScrollToElement(ButtonCreatePrflPg);

            return this;
        }

        #region DropDownMenuSelectorOfCurrentEmployer

        [AllureStep("ClickDropDownCurrentEmployerPrflPg")]
        public ProfileDetails ClickDropDownCurrentEmployerPrflPg()
        {
            Button.Click(DropDownCurrentEmployerPrflPg);

            return this;
        }

        private static IWebElement element;

        [AllureStep("SelectorCurrentEmployerDropDownPrflPg")]
        public static IList<IWebElement> SelectorCurrentEmployerDropDownPrflPg(string _locationItem)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@role = 'listbox']";
            element = Browser._Driver.FindElement(By.XPath(str));
            return element.FindElements(By.XPath($".//span[contains(text(), '{_locationItem}')]"));
        }

        [AllureStep("SelectCurrentEmployerDropDownPrflP")]
        public ProfileDetails SelectCurrentEmployerDropDownPrflP(int item, string locationItem)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _item = SelectorCurrentEmployerDropDownPrflPg(locationItem);

            _item[item].Click();

            return this;
        }

        #endregion

        [AllureStep("EnterDataJobTitleRestriction")]
        public ProfileDetails EnterDataJobTitleRestriction()
        {
            InputGeneral.InputFunctionWithClear(FieldInputIJobTitlePrflPg, Lorem.Word());
            InputGeneral.InputFunctionWithClear(FieldInputIRestrictionPrflPg, Lorem.Sentence() + GenerateRandomDataHelper.RandomNumberCharacter(10));

            return this;
        }

        [AllureStep("ClickButtonCreatePrflPg")]
        public ProfileDetails ClickButtonCreatePrflPg()
        {
            Button.Click(ButtonCreatePrflPg);

            return this;
        }

        [AllureStep("CopyEmailFromProfiledetails")]
        public string CopyEmailFromProfiledetails()
        {
            WaitUntil.WaitSomeInterval(1);
            string getemail = Browser._Driver.FindElement(_FieldInputEmailAddressPrflPgForGet).GetAttribute("value");
            string email = getemail.ToLower();

            return email;
        }

    }
}
