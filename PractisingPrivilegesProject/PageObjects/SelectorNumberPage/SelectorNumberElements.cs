using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.SelectorNumberPage
{
    public partial class SelectorNumberPagesForAllPages
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'mat-select-trigger')]")]
        public IWebElement DropDownSelectorNumber;
    }
}
