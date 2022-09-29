using CazamioProgect.Helpers;
using OpenQA.Selenium;
using PractisingPrivilegesProject.PageObjects.HeaderPage;
using PractisingPrivilegesProject.PageObjects.LogInPage;
using PractisingPrivilegesProject.PageObjects.MdlWndwSelectSpecialtiesPage;
using PractisingPrivilegesProject.PageObjects.ProfileDetailsPage;
using PractisingPrivilegesProject.PageObjects.UsersManagementPage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static LogIn LogIn => GetPage<LogIn>();
        public static Header Header => GetPage<Header>();
        public static UsersManagement UsersManagement => GetPage<UsersManagement>();
        public static ProfileDetails ProfileDetails => GetPage<ProfileDetails>();
        public static MdlWndwSelectSpecialties MdlWndwSelectSpecialties => GetPage<MdlWndwSelectSpecialties>();
    }
}
