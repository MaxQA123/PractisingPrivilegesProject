using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.SelectorNumberPage
{
    public partial class SelectorNumberPagesForAllPages
    {
        [AllureStep("ClickDropDownSelectorNumberForLocationEmployersDocsRolesPgs")]
        public SelectorNumberPagesForAllPages ClickDropDownSelectorNumberForLocationEmployersDocsRolesPgs()
        {
            Button.Click(DropDownSelectorNumberForLocationEmployersDocsRolesPgs);

            return this;
        }

        [AllureStep("ClickDropDownSelectorNumberForUsersMngmntPg")]
        public SelectorNumberPagesForAllPages ClickDropDownSelectorNumberForUsersMngmntPg()
        {
            Button.Click(DropDownSelectorNumberForUsersMngmnt);

            return this;
        }

        private static IWebElement _elementLocation;

        [AllureStep("SelectorNumberPage")]
        public static IList<IWebElement> SelectorNumberPage(string _locationNumberPage)
        {
            WaitUntil.WaitSomeInterval(3000);
            var str = "//div[@role = 'listbox']";
            _elementLocation = Browser._Driver.FindElement(By.XPath(str));
            return _elementLocation.FindElements(By.XPath($".//mat-option[contains(@id, '{_locationNumberPage}')]"));
        }

        [AllureStep("SelectNumberPage")]
        public SelectorNumberPagesForAllPages SelectNumberPage(int numberPageLocationPage, string locationNumberPage)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _numberPageLocationPage = SelectorNumberPage(locationNumberPage);

            _numberPageLocationPage[numberPageLocationPage].Click();

            return this;
        }
    }
}
