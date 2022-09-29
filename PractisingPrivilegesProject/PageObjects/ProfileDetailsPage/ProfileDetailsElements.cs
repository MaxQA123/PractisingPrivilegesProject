using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
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

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'mat-select-arrow')]")]
        public IWebElement DropDownMenuSelectorRolesPrflPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' Clinician']")]
        public IWebElement CheckBoxClinicianPrflPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' Admin']")]
        public IWebElement CheckBoxAdminPrflPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' Approver']")]
        public IWebElement CheckBoxApproverPrflPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' Viewer']")]
        public IWebElement CheckBoxViewerPrflPg;

        #endregion

        #region MandatoryFildsToFillIn

        [FindsBy(How = How.XPath, Using = "//input[@name = 'First name']")]
        public IWebElement FieldInputFirstNamePrflPg;

        [FindsBy(How = How.XPath, Using = "//input[@name = 'Last name']")]
        public IWebElement FieldInputLastNamePrflPg;

        [FindsBy(How = How.XPath, Using = "//input[@name = 'Email address']")]
        public IWebElement FieldInputEmailAddressPrflPg;

        [FindsBy(How = How.XPath, Using = "//input[@name = 'Contact telephone number']")]
        public IWebElement FieldInputContactTelephoneNumberPrflPg;

        [FindsBy(How = How.XPath, Using = "//code-input/span/input")]
        public IWebElement FieldInputFirstPersonalIdentificationNumberPrflPg;

        [FindsBy(How = How.XPath, Using = "//code-input/span[2]/input")]
        public IWebElement FieldInputSecondPersonalIdentificationNumberPrflPg;

        [FindsBy(How = How.XPath, Using = "/code-input/span[3]/input")]
        public IWebElement FieldInputThirdPersonalIdentificationNumberPrflPg;

        [FindsBy(How = How.XPath, Using = "//code-input/span[4]/input")]
        public IWebElement FieldInputFourthPersonalIdentificationNumberPrflPg;

        #endregion
    }
}
