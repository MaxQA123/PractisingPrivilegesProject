using PractisingPrivileges.Helpers;
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
using PractisingPrivilegesProject.Helpers;
using PractisingPrivilegesProject.PageObjects.EmailXitrooPage;
using PractisingPrivilegesProject.PageObjects.SetPasswordPage;
using PractisingPrivilegesProject.PageObjects.VerificationCodePage;
using PractisingPrivilegesProject.PageObjects.UserProfilePage;
using PractisingPrivilegesProject.PageObjects.ForgotPasswordPage;

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
        public static SwitchingJScriptExecutorHelper SwitchingJScriptExecutorHelper => GetPage<SwitchingJScriptExecutorHelper>();
        public static EmailXitroo EmailXitroo => GetPage<EmailXitroo>();
        public static SetPassword SetPassword => GetPage<SetPassword>();
        public static VerificationCode VerificationCode => GetPage<VerificationCode>();
        public static UserProfile UserProfile => GetPage<UserProfile>();
        public static ForgotPassword ForgotPassword => GetPage<ForgotPassword>();
    }
}
