using PractisingPrivileges.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.HeaderPage
{
    public partial class Header
    {
        [FindsBy(How = How.XPath, Using = "//div[@class = 'mat-menu-trigger avatar']//img[contains(@src, '../../assets/img/default_avatar.svg')]")]
        public IWebElement IconEmptyForImageAvatar;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'mat-menu-trigger avatar']//img[contains(@src, 'data:')]")]
        public IWebElement IconWithImageForImageAvatar;

        public IWebElement TextNameRoleOnHeader => Browser._Driver.FindElement(_TextNameRoleOnHeader);
        public readonly static By _TextNameRoleOnHeader = By.XPath("//div[@class = 'mat-menu-trigger avatar']//span");

        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'mat-focus-indicator mat-menu-item ng-tns')]")]
        public IWebElement ItemProfileFromDropDownHeader;

        [FindsBy(How = How.XPath, Using = "//button[contains(@class, 'mat-focus-indicator mat-menu-item ng-tns')][2]")]
        public IWebElement ItemLogOutFromDropDownHeader;
    }
}
