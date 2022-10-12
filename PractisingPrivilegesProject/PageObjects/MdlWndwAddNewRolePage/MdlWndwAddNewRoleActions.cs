using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.MdlWndwAddNewRolePage
{
    public partial class MdlWndwAddNewRole
    {
        [AllureStep("EnterNameRoleForDoc")]
        public MdlWndwAddNewRole EnterNameRoleForDoc()
        {
            InputGeneral.InputFunctionWithClear(FieldInputNameMdlWndwAddNewRole, TestDataNameRoles.ROLE_TESTING);

            return this;
        }

        [AllureStep("ClickFieldInputNameMdlWndwAddNewRole")]
        public MdlWndwAddNewRole ClickFieldInputNameMdlWndwAddNewRole()
        {
            Button.Click(FieldInputNameMdlWndwAddNewRole);

            return this;
        }

        [AllureStep("ClickDropDownSelectorDocsMdlWndwAddNewRole")]
        public MdlWndwAddNewRole ClickDropDownSelectorDocsMdlWndwAddNewRole()
        {
            Button.Click(DropDownSelectorDocsMdlWndwAddNewRole);

            return this;
        }

        private static IWebElement _element;

        [AllureStep("SelectorForDocsMdlWndwAddNewRole")]
        public static IList<IWebElement> SelectorForDocsMdlWndwAddNewRole(string _locationDocument)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//div[@role= 'listbox']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//mat-option[contains(@id, '{_locationDocument}')]"));
        }

        [AllureStep("SelectDocsMdlWndwAddNewRole")]
        public MdlWndwAddNewRole SelectDocsMdlWndwAddNewRole(int document, string locationDocument)
        {
            WaitUntil.WaitSomeInterval(500);
            IList<IWebElement> _document = SelectorForDocsMdlWndwAddNewRole(locationDocument);

            _document[document].Click();

            return this;
        }

        [AllureStep("SelectDocsMdlWndwAddNewRole")]
        public MdlWndwAddNewRole SelectDocsMdlWndwAddNewRole()
        {
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            KeyBoardActions.ClickArrowDown();
            KeyBoardActions.ClickEnterButton();
            KeyBoardActions.ClickEscapeButton();

            return this;
        }

        [AllureStep("ClickButtonCreateMdlWndwAddNewDocs")]
        public MdlWndwAddNewRole ClickButtonCreateMdlWndwAddNewDocs()
        {
            Button.Click(ButtonCreateMdlWndwAddNewDocs);

            return this;
        }
    }
}
