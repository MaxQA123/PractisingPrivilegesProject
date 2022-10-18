﻿using PractisingPrivilegesProject.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PractisingPrivileges.Helpers;

namespace ClinicianTests
{
    public class WebBaseClinician : BaseWeb
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(EndPoints.urlWebSite);
        }
    }
}
