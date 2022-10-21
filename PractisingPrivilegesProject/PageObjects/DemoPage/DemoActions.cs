using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.PageObjects
{
    public partial class DemoTest
    {
        [AllureStep("SigningInAsSuperAdmin")]
        public DemoTest SigningInAsSuperAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataAdmin.emailAdminQatester);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataAdmin.passwordNewAdminQatester);
            Button.Click(ButtonSignInLogInPg);
            //if (ButtonSignInLogInPg.Displayed == true)
            //{

            //    InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, TestDataAdmin.emailAdminQatester);
            //    InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, TestDataGeneral.generalPassword);
            //    Button.Click(ButtonSignInLogInPg);
            //}
            return this;
        }

        [AllureStep("GetDemoFirstNameFromUserProfile")]
        public string GetDemoFirstNameFromUserProfile()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getFirstName = TextNameRoleOnHeader.Text.Substring(0, TextNameRoleOnHeader.Text.IndexOf(" "));
            string firstNameActual = getFirstName.ToString();

            Console.WriteLine(firstNameActual);

            return firstNameActual;
        }

        [AllureStep("GetDemoLastName")]
        public string GetDemoLastName()
        {
            WaitUntil.WaitSomeInterval(3000);
            string getLastName = TextNameRoleOnHeader.Text;
            Regex regexGetLastName = new Regex(@"[^\s]+$");
            string lastNameActual = regexGetLastName.Match(getLastName).ToString();

            Console.WriteLine(lastNameActual);

            return lastNameActual;
        }

        public static void DemoCustomElementIsInVisible(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
            try
            {
                wait.Until(e =>
                {
                    try
                    {
                        if (element.Enabled == true)
                        {
                            Console.WriteLine(element.Text);
                            //InputGeneral.InputFunctionWithClear(Browser._Driver.FindElement(_FieldInputEmailLogInPg), TestDataAdmin.emailAdminQatester);
                            //InputGeneral.InputFunctionWithClear(Browser._Driver.FindElement(_FieldInputPasswordLogInPg), TestDataAdmin.passwordNewAdminQatester);
                            //WaitUntil.WaitSomeInterval(250);
                            //Button.Click(Browser._Driver.FindElement(_ButtonSignInLogInPg));
                            return true;
                        }
                        return false;
                    }
                    catch (NoSuchElementException)
                    {
                        return true;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return true;
                    }

                });
            }
            catch (NoSuchElementException) { }
            catch (StaleElementReferenceException) { }
        }
    }
}
