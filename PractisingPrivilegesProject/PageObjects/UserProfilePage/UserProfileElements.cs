using OpenQA.Selenium;
using PractisingPrivileges.Helpers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects.UserProfilePage
{
    public partial class UserProfile
    {
        [FindsBy(How = How.XPath, Using = "//button[@aria-label= 'Edit']")]
        public IWebElement ButtonEditUserProfilePg;

        IWebElement FirstNameUserProfilePg => Browser._Driver.FindElement(_FirstNameUserProfilePg);
        public static readonly By _FirstNameUserProfilePg = By.XPath("//input[@class= 'ng-untouched ng-pristine ng-star-inserted']");

        //[FindsBy(How = How.XPath, Using = "//button[@aria-label= 'Edit']")]
        //public IWebElement ButtonEditUserProfilePg;

        //[FindsBy(How = How.XPath, Using = "//button[@aria-label= 'Edit']")]
        //public IWebElement ButtonEditUserProfilePg;

        //[FindsBy(How = How.XPath, Using = "//button[@aria-label= 'Edit']")]
        //public IWebElement ButtonEditUserProfilePg;
    }
}
