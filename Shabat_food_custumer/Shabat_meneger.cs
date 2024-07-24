using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shabat_food_custumer
{
    internal class Shabat_meneger
    {
        // משתנה שמכיל את ה SQL של גל הקטגוריות
        private static string _ReceivingCustomers = System.IO.File.ReadAllText(
            "C:\\_kodcode2\\Shabat_food_custumer\\SQL\\getCustumer.sql"
        );

        // משתנה שמכיל את כל ההזמנות לפי חיפוש של קטגוריות
        private static string _OrdersByCustomers = "";

        // משתנה שמכיל את ה SQL של ההוספה של קטגוריות
        private static string _AddCustomer = System.IO.File.ReadAllText(
            "C:\\_kodcode2\\Shabat_food_custumer\\SQL\\addCustumer.sql"
        );

        // מחיקת קטגוריה
        private static string _DeleteCustomer = "SELECT full_name FROM Person";

        public static List<string> GetCustomers()
        {
            SqlDataReader reader = DBConnection.RunSQLAllResult(_ReceivingCustomers);
            List<string> customers = new List<string>();
            for (int i = 0; reader.Read() != false; i++)
            {
                customers.Add(reader.GetString(0));
            }
            reader.Close();
            return customers;
        }

        public static DataTable CustomerOrders(string category, DataTable table)
        {
            string[] parameters = { "@food_category" };
            string[] values = { category };
            table = DBConnection.GetDataTable(_OrdersByCustomers, parameters, values, table);

            return table;
        }

        public static void AddCustomer(string customer)
        {
            string[] parameters = { "@person" };
            string[] values = { customer };
            DBConnection.NoReturnValue(_AddCustomer, parameters, values);
        }

        public static void DeleteCustomer(string category)
        {
            string[] parameters = { "@category_name" };
            string[] values = { category };
            DBConnection.NoReturnValue(_DeleteCustomer, parameters, values);
        }
    }
}
