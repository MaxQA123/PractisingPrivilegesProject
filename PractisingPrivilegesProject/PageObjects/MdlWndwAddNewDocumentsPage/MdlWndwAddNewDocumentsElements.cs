using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewDocumentsPage
{
    public partial class MdlWndwAddNewDocuments
    {
        IWebElement FieldInputNameMdlWndwAddNewDocs => Browser._Driver.FindElement(_FieldInputNameMdlWndwAddNewDocs);
        public static readonly By _FieldInputNameMdlWndwAddNewDocs = By.XPath("//input[@placeholder= 'Name']");

        [FindsBy(How = How.XPath, Using = "//mat-select[@role = 'combobox']//div[contains(@class, 'mat-select-trigger')]")]
        public IWebElement DropDownSelectorFormatFileMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[@role = 'listbox']//mat-option[contains(@id, 'mat-option')]")]
        public IWebElement CheckBoxPdfFormatFileMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[@role = 'listbox']//mat-option[contains(@id, 'mat-option')][2]")]
        public IWebElement CheckBoxPhotoFormatFileMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[@role = 'listbox']//mat-option[contains(@id, 'mat-option')][3]")]
        public IWebElement CheckBoxWordDocFormatFileMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'column ng-tn')]//mat-checkbox[@formcontrolname = 'isInformationOnly']")]
        public IWebElement CheckBoxInformationOnlyMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'column ng-tn')]//mat-checkbox[@formcontrolname = 'canSnooze']")]
        public IWebElement CheckBoxCanSnoozeMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'column ng-tn')]//mat-checkbox[@formcontrolname = 'automaticStop']")]
        public IWebElement CheckBoxAutomaticStopMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'column ng-tn')]//mat-checkbox[@formcontrolname = 'visible']")]
        public IWebElement CheckBoxVisibleToViewersMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'area ng-tns')]//div[contains(@class, 'column ng-tn')][2]//mat-checkbox[@formcontrolname = 'renewalRequired']")]
        public IWebElement CheckBoxRenewalRequiredMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'area ng-tns')]//div[contains(@class, 'column ng-tn')][2]//mat-checkbox[@formcontrolname = 'isTermsAndConditions']")]
        public IWebElement CheckBoxTermsAndConditionsMdlWndwAddNewDocs;

        #region RenewalRequiredTimeFrame

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement CheckBoxTermsAndConditionsMdlWndwAddNewDocs;

        #endregion
    }
}
