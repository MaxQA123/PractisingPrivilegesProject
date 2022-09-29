using CazamioProgect.Helpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwSelectSpecialtiesPage
{
    public partial class MdlWndwSelectSpecialties
    {
        private static IWebElement _element;

        [AllureStep("SelectorItemSpecialtiesMdlWndw")]
        public static IList<IWebElement> SelectorItemSpecialtiesMdlWndw(string _locationItem)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class= 'mat-dialog-content']//div[@class = 'content']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationItem}')]"));
        }

        [AllureStep("SelectItemSpecialtiesMdlWndw")]
        public MdlWndwSelectSpecialties SelectItemSpecialtiesMdlWndw(int item, string locationItem)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _item = SelectorItemSpecialtiesMdlWndw(locationItem);

            _item[item].Click();

            return this;
        }

        [AllureStep("SelectorItemLocationsMdlWndw")]
        public static IList<IWebElement> SelectorItemLocationsMdlWndw(string _locationItem)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@class= 'mat-dialog-content']//div[@class = 'content']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//div[contains(@class, '{_locationItem}')]"));
        }

        [AllureStep("SelectItemLocationsMdlWndw")]
        public MdlWndwSelectSpecialties SelectItemLocationsMdlWndw(int item, string locationItem)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _item = SelectorItemLocationsMdlWndw(locationItem);

            _item[item].Click();

            return this;
        }

        [AllureStep("ClickButtonAddMdlWndwSpecialtiesLocations")]
        public MdlWndwSelectSpecialties ClickButtonAddMdlWndwSpecialtiesLocations()
        {
            Button.Click(ButtonAddMdlWndwSpecialtiesLocations);

            return this;
        }
    }
}
