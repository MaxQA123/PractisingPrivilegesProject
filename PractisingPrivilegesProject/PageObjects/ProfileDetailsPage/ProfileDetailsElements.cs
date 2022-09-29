﻿using OpenQA.Selenium;
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

        //div[contains(@class, 'mat-select-arrow')]
        //mat-select[@id = 'mat-select-0']
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

        [FindsBy(How = How.XPath, Using = "//form//div[@class = 'column'][2]//div[@class = 'gmc']//input")]
        public IWebElement FieldInputGmcPrflPg;

        [FindsBy(How = How.XPath, Using = "//form//div[@class = 'column']//div[@class = 'gmc']//mat-icon")]
        public IWebElement IconForSaveGmcPrflPg;

        [FindsBy(How = How.XPath, Using = "//form//div[@class = 'column'][2]//div[@class = 'gmc'][2]//input")]
        public IWebElement FieldInputImcPrflPg;

        [FindsBy(How = How.XPath, Using = "//form//div[@class = 'column'][2]//div[@class = 'gmc'][2]//mat-icon")]
        public IWebElement IconForSaveImcPrflPg;

        #endregion

        #region DropDownMenuSelectorOfTitle

        [FindsBy(How = How.XPath, Using = "//app-clinician//div[@class= 'column']//div[contains(@class, 'mat-select-arrow-wrapper')]")]
        public IWebElement DropDownMenuSelectorTitlePrflPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' Dr ']")]
        public IWebElement ItemDrPrflPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' Mr ']")]
        public IWebElement ItemMrPrflPg;

        [FindsBy(How = How.XPath, Using = "//span[text() = ' Prof ']")]
        public IWebElement ItemProfPrflPg;

        #endregion

        
        [FindsBy(How = How.XPath, Using = "//app-list[@header = 'Specialty']//div[@class = 'actions ng-star-inserted']//mat-icon")]
        public IWebElement ButtonSpecialtyPrflPg;

        [FindsBy(How = How.XPath, Using = "//app-list[@header = 'Location']//div[@class = 'actions ng-star-inserted']//mat-icon")]
        public IWebElement ButtonLocationPrflPg;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'cdk-overlay-backdrop cdk-overlay-transparent-backdrop cdk-overlay-backdrop-showing']")]
        public IWebElement AllPageProfileDetails;

    }
}