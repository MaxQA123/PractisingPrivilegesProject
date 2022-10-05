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

        [FindsBy(How = How.XPath, Using = "//app-upload-from-computer//div[@class = 'computer']//input[contains(@accept, ' , .pdf')]")]
        public IWebElement LinkUploadFileMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//app-form-error//div[@class = 'validation-errors']//div[text() = ' You must enter a value ']")]
        public IWebElement ErrorMessageYouMustEnterValueMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//ul//div[text() = ' This file invalid ']")]
        public IWebElement ErrorMessageThisFileInvalidMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//div[text() = ' Please remove invalid files ']")]
        public IWebElement ErrorMessagePleaseRemoveInvalidFilesMdlWndwAddNewDocs;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Add']")]
        public IWebElement ButtonAddMdlWndwAddNewDocs;

        #region RenewalTimeFrame

        [FindsBy(How = How.XPath, Using = "//app-duration-picker[@label = 'Renewal Timeframe']//input[@id = 'hours']")]
        public IWebElement FieldInputHoursRenewalTimeFrame;

        [FindsBy(How = How.XPath, Using = "//app-duration-picker[@label = 'Renewal Timeframe']//input[@id = 'days']")]
        public IWebElement FieldInputDaysRenewalTimeFrame;

        [FindsBy(How = How.XPath, Using = "//app-duration-picker[@label = 'Renewal Timeframe']//input[@id = 'months']")]
        public IWebElement FieldInputMonthsRenewalTimeFrame;

        [FindsBy(How = How.XPath, Using = "//app-duration-picker[@label = 'Renewal Timeframe']//input[@id = 'years']")]
        public IWebElement FieldInputYearsRenewalTimeFrame;

        #endregion

        #region ReminderTimeframe

        [FindsBy(How = How.XPath, Using = "//app-duration-picker[@label = 'Reminder Timeframe']//input[@id = 'hours']")]
        public IWebElement FieldInputHoursReminderTimeFrame;

        [FindsBy(How = How.XPath, Using = "//app-duration-picker[@label = 'Reminder Timeframe']//input[@id = 'days']")]
        public IWebElement FieldInputDaysReminderTimeFrame;

        [FindsBy(How = How.XPath, Using = "//app-duration-picker[@label = 'Reminder Timeframe']//input[@id = 'months']")]
        public IWebElement FieldInputMonthsReminderTimeFrame;

        [FindsBy(How = How.XPath, Using = "//app-duration-picker[@label = 'Reminder Timeframe']//input[@id = 'years']")]
        public IWebElement FieldInputYearsReminderTimeFrame;

        #endregion

        #region ReminderFrequency

        [FindsBy(How = How.XPath, Using = "//mat-button-toggle//button[contains(@id, 'mat-button-toggle')]//span[text() = 'Every Hours']")]
        public IWebElement ButtonEveryHoursReminderFrequency;

        [FindsBy(How = How.XPath, Using = "//mat-button-toggle//button[contains(@id, 'mat-button-toggle')]//span[text() = 'Every Days']")]
        public IWebElement ButtonEveryDaysReminderFrequency;

        [FindsBy(How = How.XPath, Using = "//mat-button-toggle//button[contains(@id, 'mat-button-toggle')]//span[text() = 'Every Months']")]
        public IWebElement ButtonEveryMonthsReminderFrequency;

        [FindsBy(How = How.XPath, Using = "//app-interval-duration-picker//div[@class = 'inputs']//input[@id =  'hours']")]
        public IWebElement FieldInputEveryHoursReminderFrequency;

        [FindsBy(How = How.XPath, Using = "//app-interval-duration-picker//div[@class = 'inputs']//input[@id =  'days']")]
        public IWebElement FieldInputEveryDaysReminderFrequency;

        [FindsBy(How = How.XPath, Using = "//app-interval-duration-picker//div[@class = 'inputs']//input[@id =  'months']")]
        public IWebElement FieldInputEveryMonthsReminderFrequency;

        #endregion
    }
}
