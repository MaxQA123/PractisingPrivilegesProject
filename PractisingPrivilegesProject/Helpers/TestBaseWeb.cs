using NUnit.Framework;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivileges.Helpers
{
    public class TestsBaseWeb : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(EndPoints.urlWebSite);
        }

    }
}

