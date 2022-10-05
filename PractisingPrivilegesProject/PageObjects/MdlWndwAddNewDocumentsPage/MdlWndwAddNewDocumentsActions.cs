using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewDocumentsPage
{
    public partial class MdlWndwAddNewDocuments
    {
        [AllureStep("EnterFieldInputNameMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments EnterFieldInputNameMdlWndwAddNewDocs()
        {
            InputGeneral.InputFunctionWithClear(FieldInputNameMdlWndwAddNewDocs, TestDataNameDocumnets.testing);

            return this;
        }

        [AllureStep("SelectAllFormatFilesMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments SelectAllFormatFilesMdlWndwAddNewDocs()
        {
            Button.Click(DropDownSelectorFormatFileMdlWndwAddNewDocs);
            Button.Click(CheckBoxPhotoFormatFileMdlWndwAddNewDocs);
            Button.Click(CheckBoxWordDocFormatFileMdlWndwAddNewDocs);
            KeyBoardActions.ClickEscapeButton();
            WaitUntil.WaitSomeInterval(1000);


            return this;
        }

        [AllureStep("ClickCheckBoxInformationOnlyMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments ClickCheckBoxInformationOnlyMdlWndwAddNewDocs()
        {
            Button.Click(CheckBoxInformationOnlyMdlWndwAddNewDocs);

            return this;
        }

        [AllureStep("CheckBoxCanSnoozeMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments ClickCheckBoxCanSnoozeMdlWndwAddNewDocs()
        {
            Button.Click(CheckBoxCanSnoozeMdlWndwAddNewDocs);

            return this;
        }

        [AllureStep("ClickCheckBoxAutomaticStopMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments ClickCheckBoxAutomaticStopMdlWndwAddNewDocs()
        {
            Button.Click(CheckBoxAutomaticStopMdlWndwAddNewDocs);

            return this;
        }

        [AllureStep("ClickCheckBoxVisibleToViewersMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments ClickCheckBoxVisibleToViewersMdlWndwAddNewDocs()
        {
            Button.Click(CheckBoxVisibleToViewersMdlWndwAddNewDocs);

            return this;
        }

        [AllureStep("ClickCheckBoxRenewalRequiredMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments ClickCheckBoxRenewalRequiredMdlWndwAddNewDocs()
        {
            Button.Click(CheckBoxRenewalRequiredMdlWndwAddNewDocs);

            return this;
        }

        [AllureStep("EnterRenewalTimeFramMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments EnterRenewalTimeFramMdlWndwAddNewDocs()
        {
            InputGeneral.InputFunctionWithClear(FieldInputHoursRenewalTimeFrame, TestDataForRenewalTimeframe.hours);
            InputGeneral.InputFunctionWithClear(FieldInputDaysRenewalTimeFrame, TestDataForRenewalTimeframe.days);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsRenewalTimeFrame, TestDataForRenewalTimeframe.months);
            InputGeneral.InputFunctionWithClear(FieldInputYearsRenewalTimeFrame, TestDataForRenewalTimeframe.years);

            return this;
        }

        [AllureStep("EnterReminderTimeFramMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments EnterReminderTimeFramMdlWndwAddNewDocs()
        {
            InputGeneral.InputFunctionWithClear(FieldInputHoursReminderTimeFrame, TestDataForReminderTimeframe.hours);
            InputGeneral.InputFunctionWithClear(FieldInputDaysReminderTimeFrame, TestDataForReminderTimeframe.days);
            InputGeneral.InputFunctionWithClear(FieldInputMonthsReminderTimeFrame, TestDataForReminderTimeframe.months);
            InputGeneral.InputFunctionWithClear(FieldInputYearsReminderTimeFrame, TestDataForReminderTimeframe.years);

            return this;
        }

        [AllureStep("SetEveryHoursReminderFrequency")]
        public MdlWndwAddNewDocuments SetEveryHoursReminderFrequency()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonEveryHoursReminderFrequency);
            InputGeneral.InputFunctionWithClear(FieldInputEveryHoursReminderFrequency, TestDataReminderFrequency.hours);

            return this;
        }

        [AllureStep("SetEveryDaysReminderFrequency")]
        public MdlWndwAddNewDocuments SetEveryDaysReminderFrequency()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonEveryDaysReminderFrequency);
            InputGeneral.InputFunctionWithClear(FieldInputEveryDaysReminderFrequency, TestDataReminderFrequency.days);

            return this;
        }

        [AllureStep("SetEveryMonthsReminderFrequency")]
        public MdlWndwAddNewDocuments SetEveryMonthsReminderFrequency()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonEveryMonthsReminderFrequency);
            InputGeneral.InputFunctionWithClear(FieldInputEveryMonthsReminderFrequency, TestDataReminderFrequency.months);

            return this;
        }

        [AllureStep("UploadDocuments")]
        public MdlWndwAddNewDocuments UploadDocuments()
        {
            WaitUntil.WaitSomeInterval(1000);
            LinkUploadFileMdlWndwAddNewDocs.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.pdfDocumentTestingOne));
            WaitUntil.WaitSomeInterval(250);
            LinkUploadFileMdlWndwAddNewDocs.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.photoDocumentTestingTwo));
            WaitUntil.WaitSomeInterval(250);
            LinkUploadFileMdlWndwAddNewDocs.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.wordDocDocumentTestQA));
            WaitUntil.WaitSomeInterval(250);
            LinkUploadFileMdlWndwAddNewDocs.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.wordDocxDocumentTextDocument));
            WaitUntil.WaitSomeInterval(250);
            LinkUploadFileMdlWndwAddNewDocs.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.pngDocumentRobot123));
            WaitUntil.WaitSomeInterval(250);
            LinkUploadFileMdlWndwAddNewDocs.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.jpegDocumentDocument444));

            return this;
        }

        [AllureStep("ClickButtonAddMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments ClickButtonAddMdlWndwAddNewDocs()
        {
            Button.Click(ButtonAddMdlWndwAddNewDocs);

            return this;
        }
    }
}
