using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
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
            InputGeneral.InputFunctionWithClear(FieldInputNameMdlWndwAddNewDocs, TestDataNameDocumnets.requiresRenewalOneTwoThree);

            return this;
        }

        [AllureStep("SelectAllFormatFilesMdlWndwAddNewDocs")]
        public MdlWndwAddNewDocuments SelectAllFormatFilesMdlWndwAddNewDocs()
        {
            Button.Click(DropDownSelectorFormatFileMdlWndwAddNewDocs);
            Button.Click(CheckBoxPhotoFormatFileMdlWndwAddNewDocs);
            Button.Click(CheckBoxWordDocFormatFileMdlWndwAddNewDocs);
            KeyBoardActions.ClickEscapeButton();


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

        private static IWebElement _element;

        [AllureStep("SelectorRenewalTimeframe")]
        public static IList<IWebElement> SelectorRenewalTimeframe(string _locationDay)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[contains(@class, 'column ng-tn')][2]//app-duration-picker[@label = 'Renewal Timeframe']//div[@class = 'inputs']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//td[contains(@class, '{_locationDay}')]"));
        }

        [AllureStep("SelectRenewalTimeframe")]
        public MdlWndwAddNewDocuments SelectRenewalTimeframe(int day, string locationDay)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _day = SelectorRenewalTimeframe(locationDay);

            _day[day].Click();

            return this;
        }
    }
}
