using NUnit.Framework;
using PractisingPrivileges.Helpers;
using PractisingPrivilegesProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewerTests
{
    public class WebBaseViewer : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser._Driver.Navigate().GoToUrl(EndPoints.urlWebSite);
        }
    }
}
