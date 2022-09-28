using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingPrivilegesApiTests.ApiPagesObjects.LogInApiPage
{
    public partial class LogInApi
    {
        public static void VerifyingLoggedUserRandom(ResponseLogIn response, string message)
        {
            Assert.AreEqual(message, response.message);
        }

        public static void VerifyingLoggedUserConst(ResponseLogIn response)
        {
            Assert.AreEqual("Successful operation.", response.message);
        }
    }
}
