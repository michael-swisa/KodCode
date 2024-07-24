using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
    internal class College_meneger
    {
        // משתנה שמכיל את ה SQL של הקורסים
        private static string _ReceivingCourses = System.IO.File.ReadAllText(
            "C:\\Users\\Admin\\source\\repos\\college\\SQL\\Receiving_courses.sql"
        );

        private static string _AddUser = System.IO.File.ReadAllText(
            "C:\\Users\\Admin\\source\\repos\\college\\SQL\\add_user.sql"
        );

        public static List<string> GetCourses()
        {
            SqlDataReader reader = DBConnection.RunSQLAllResult(_ReceivingCourses);
            List<string> courses = new List<string>();
            for (int i = 0; reader.Read() != false; i++)
            {
                courses.Add(reader.GetString(4));
            }
            reader.Close();
            return courses;
        }

        public static string AddUser(string fullName, String course)
        {
            string[] parameters = { "@FullName", "@CourseName" };
            string[] values = { fullName, course };
            SqlDataReader result = DBConnection.RunSQLAllResult(_AddUser, parameters, values);

            //string preice = result.GetString().ToString();
            //return preice;
            List<int> price = new List<int>();
            for (int i = 0; result.Read() != false; i++)
            {
                price.Add(result.GetInt32(0));
            }
            result.Close();
            return price[0].ToString();

            result.Close();
        }

        //                public static DataTable CategoryOrders(string category, DataTable table)
        //        {
        //            string[] parameters = { "@food_category" };
        //            string[] values = { category };
        //            table = DBConnection.GetDataTable(_OrdersByCategories, parameters, values, table);

        //            return table;
        //        }



        //        public static void DeleteCategory(string category)
        //        {
        //            string[] parameters = { "@category_name" };
        //            string[] values = { category };
        //            DBConnection.NoReturnValue(_DeleteCategory, parameters, values);
        //        }
        //    }
        //}
    }
}
