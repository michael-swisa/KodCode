using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VendingMachine
{
    internal class MainProject
    {
        public MainProject() { }

        public static string _pathString = Path.GetFullPath(
            Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Drinks.xml"
        );

        public static XmlDocument Main()
        {
            Console.WriteLine("Hello, World!");

            // 1. Read the XML File from file system
            // 1.1 Define the location of the file in the file system
            Console.WriteLine("Project Directory: " + _pathString);

            // 1.2 Check if file exists
            if (File.Exists(_pathString))
            {
                // 1.3 Create a new instance of type XmlDocument
                XmlDocument xmlDoc = new XmlDocument();
                // 1.4 Try and load the XML content into the XmlDocument object
                xmlDoc.Load(_pathString);
                return xmlDoc;
            }
            return null;
        }

        public static void Save(XmlDocument Doc)
        {
            Doc.Save(_pathString);
        }
    }
}
