using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shabat_food_host
{
    internal class Shabat_meneger
    {
        // משתנה שמכיל את ה SQL של גל הקטגוריות
        private static string _ReceivingCategories = System.IO.File.ReadAllText(
            "C:\\_kodcode2\\shabat_food_host\\SQL\\Receiving_categories.sql"
        );

        // משתנה שמכיל את כל ההזמנות לפי חיפוש של קטגוריות
        private static string _OrdersByCategories = System.IO.File.ReadAllText(
            "C:\\_kodcode2\\shabat_food_host\\SQL\\CategoryOrders.sql"
        );

        // משתנה שמכיל את ה SQL של ההוספה של קטגוריות
        private static string _AddCategory = System.IO.File.ReadAllText(
            "C:\\_kodcode2\\shabat_food_host\\SQL\\AddCategory.sql"
        );

        // מחיקת קטגוריה
        private static string _DeleteCategory = System.IO.File.ReadAllText(
            "C:\\_kodcode2\\shabat_food_host\\SQL\\DelCategory.sql"
        );

        public static List<string> GetCategories()
        {
            SqlDataReader reader = DBConnection.RunSQLAllResult(_ReceivingCategories);
            List<string> categories = new List<string>();
            for (int i = 0; reader.Read() != false; i++)
            {
                categories.Add(reader.GetString(0));
            }
            reader.Close();
            return categories;
        }

        public static DataTable CategoryOrders(string category, DataTable table)
        {
            string[] parameters = { "@food_category" };
            string[] values = { category };
            table = DBConnection.GetDataTable(_OrdersByCategories, parameters, values, table);

            return table;
        }

        public static void AddCategory(string category)
        {
            string[] parameters = { "@new_category" };
            string[] values = { category };
            DBConnection.NoReturnValue(_AddCategory, parameters, values);
        }

        public static void DeleteCategory(string category)
        {
            string[] parameters = { "@category_name" };
            string[] values = { category };
            DBConnection.NoReturnValue(_DeleteCategory, parameters, values);
        }
    }
}
