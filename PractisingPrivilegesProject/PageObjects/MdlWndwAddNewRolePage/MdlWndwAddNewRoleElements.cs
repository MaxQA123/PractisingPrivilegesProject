using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewRolePage
{
    public partial class MdlWndwAddNewRole
    {
        IWebElement FieldInputNameMdlWndwAddNewRole => Browser._Driver.FindElement(_FieldInputNameMdlWndwAddNewRole);
        public static readonly By _FieldInputNameMdlWndwAddNewRole = By.XPath("//input[@placeholder= 'Name']");

        [FindsBy(How = How.XPath, Using = "//mat-select[@role = 'combobox']//div[contains(@class, 'mat-select-trigger')]")]
        public IWebElement DropDownSelectorDocsMdlWndwAddNewRole;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Create']")]
        public IWebElement ButtonCreateMdlWndwAddNewDocs;
    }
}
