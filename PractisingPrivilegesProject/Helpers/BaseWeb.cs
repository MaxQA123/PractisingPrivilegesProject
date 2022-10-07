using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Diagnostics;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace PractisingPrivileges.Helpers
{
    public class BaseWeb
    {
        [OneTimeSetUp]
        public void DobeforeAllTheTests()
        {
            Browser.Initialize();
        }

        [OneTimeTearDown]
        public void DoAfterAllTheTests()
        {
            Browser.Quit();
        }

        [TearDown]

        public void DoAfterEach()
        {

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                ScreenShotHelper.MakeScreenShot();
                Browser.Close();
            }
            else if (Browser._Driver !=null)
            {
                Browser.Close();
            }
            
        }

    }
}