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

        [FindsBy(How = How.XPath, Using = "//mat-select[@class = 'mat-select ng-tns-c76-14 ng-tns-c73-13 mat-select-multiple ng-valid ng-star-inserted ng-dirty ng-touched']")]
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
    }
}
