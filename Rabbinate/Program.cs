using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rabbinate
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // 1. הגדרת קובץ לעבודה
            string _pathString = Path.GetFullPath(
                Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Rabbinate.xml"
            );
            XmlDocument XmlDoc;

            // 2. טעינת הקובץ
            if (File.Exists(_pathString))
            {
                XmlDoc = new XmlDocument();
                XmlDoc.Load(_pathString);
            }
            else // 3. יצירת הקובץ
            {
                XmlDoc = new XmlDocument();
                XmlDoc.LoadXml("<Queries></Queries>");
                XmlDoc.Save(_pathString);
            }
            RabbinateManeger manager = new RabbinateManeger(XmlDoc);
        }
    }
}
