using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClock
{
    internal class EmployeeManager
    {
        private static string _loginSQL = System.IO.File.ReadAllText(
            "C:\\_kodcode2\\TimeClock\\SQL\\login.sql"
        );
        private static string _changePasswordSQL = System.IO.File.ReadAllText(
            "C:\\_kodcode2\\TimeClock\\SQL\\Update_password.sql"
        );

        public static string Login(string id, string password, string fullName)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@password", @"fullName" };
            string[] values = { id, password, fullName };
            string result = DBConnection.RunSQLSingleResult(_loginSQL, parameters, values);
            // 3. Return response
            return result;
        }

        public static string ChangePassword(
            string id,
            string oldPass,
            string newPass,
            string confirmPass
        )
        {
            if (newPass != confirmPass)
            {
                return "Passwords do not match";
            }

            string[] parameters = { "@id", "@password", "@newPassword" };
            string[] values = { id, oldPass, newPass };
            string result = DBConnection.RunSQLSingleResult(_changePasswordSQL, parameters, values);

            return result;
        }
    }
}
