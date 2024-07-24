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

        private static string _AddLecturer = System.IO.File.ReadAllText(
            "C:\\Users\\Admin\\source\\repos\\college_Management\\SQL\\addCours.sql"
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

        public static void AddLecturer(string fullName, string price1)
        {
            string[] parameters = { "@FullName", "@price" };
            string[] values = { fullName, price1 };
            DBConnection.NoReturnValue(_AddLecturer, parameters, values);
        }

        public static void AddCourse(DateTime time, string days, string hours, int price)
        {
            string[] parameters = { "@days", "@hours" };
            string[] values = { days, hours };
            DBConnection.NoReturnV(_AddLecturer, time, price, parameters, values);
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
