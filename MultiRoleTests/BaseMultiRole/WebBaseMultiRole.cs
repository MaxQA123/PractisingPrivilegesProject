using NUnit.Framework;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiRoleTests
{
    public class WebBaseMultiRole : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(EndPoints.urlWebSite);
        }
    }
}
