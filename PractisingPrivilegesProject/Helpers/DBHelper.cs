using Microsoft.Data.SqlClient;
using NUnit.Allure.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractisingPrivilegesProject.Helpers
{
    public class WebSiteDBHelper
    {
        [AllureStep("GetUserEmail")]
        public static string GetUserEmail()
        {
            string data = null; 
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                string nameEmail = TestDataClinician.emailJaneClinician;
                SqlCommand command = new("SELECT Email" +
                    " FROM Users" + $" WHERE Email = '{nameEmail}'", db);
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data = reader.GetValue(0).ToString();
                    }
                }
            }
            return data;
        }

        [AllureStep("GetNameDocument")]
        public static string GetNameDocument()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                string nameDocument = TestDataNameDocumnets.testing;
                SqlCommand command = new("SELECT Name" +
                    " FROM Documents" + $" WHERE Name = '{nameDocument}'", db);
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data = reader.GetValue(0).ToString();
                    }
                }
            }
            return data;
        }

        [AllureStep("GetNameRole")]
        public static string GetNameRole()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                string nameRole = TestDataNameRoles.ROLE_TESTING;
                SqlCommand command = new("SELECT Name" +
                    " FROM DocumentRoles" + " WHERE Name = 'Role testing'", db);
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data = reader.GetValue(0).ToString();
                    }
                }
            }
            return data;
        }

        [AllureStep("Demo")]
        public static string Demo()
        {
            string data = null;
            using (SqlConnection db = new(ConnectionDb.GET_CONNECTION_STRING_TO_DB))
            {
                string nameEmail = TestDataClinician.emailJaneClinician;
                SqlCommand command = new("SELECT Email" +
                    " FROM Users" + $" WHERE Email = '{nameEmail}'", db);
                db.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        data = reader.GetValue(0).ToString();
                    }
                }
            }
            return data;
        }
    }
}
