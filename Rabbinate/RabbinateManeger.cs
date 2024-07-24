using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rabbinate
{
    internal class RabbinateManeger
    {
        private static XmlDocument _Document;

        public RabbinateManeger(XmlDocument Doc)
        {
            _Document = Doc;
        }

        private static List<string> GetText(List<string> list)
        {
            List<string> myList = new List<string>();

            switch (list[0])
            {
                case "ראשון":
                {
                    myList.Add("באחד בשבת ");
                    break;
                }
                case "שני":
                {
                    myList.Add("בשני בשבת ");
                    break;
                }
                case "שלישי":
                {
                    myList.Add("בשלישי בשבת ");
                    break;
                }
                case "רביעי":
                {
                    myList.Add("ברביעי בשבת ");
                    break;
                }
                case "חמישי":
                {
                    myList.Add("בחמישי בשבת ");
                    break;
                }
                case "שישי":
                {
                    myList.Add("בששי בשבת ");
                    break;
                }
            }

            switch (list[1])
            {
                case "1":
                {
                    myList.Add(" יום אחד לירח");
                    break;
                }
                case "2":
                {
                    myList.Add(" שני ימים לירח");
                    break;
                }
                case "3":
                {
                    myList.Add("שלושה ימים לירח ");
                    break;
                }
                case "4":
                {
                    myList.Add("ארבעה ימים לירח ");
                    break;
                }
                case "5":
                {
                    myList.Add("חמשה ימים לירח ");
                    break;
                }
                case "6":
                {
                    myList.Add(" ששה ימים לירח");
                    break;
                }
                case "7":
                {
                    myList.Add(" שבעה ימים לירח");
                    break;
                }
            }

            myList.Add(list[2]);

            return myList;
        }

        public static string GetToString(List<string> list)
        {
            string text = "";

            IList<string> MyList = GetText(list);

            foreach (var item in MyList)
            {
                text += item;
            }

            return text;
        }

        private static XmlNode GetRoot()
        {
            return _Document.GetElementsByTagName("Queries")[0];
        }

        public static void Save(List<string> list)
        {
            IList<string> listValue = GetText(list);
            string result = GetToString(list);

            XmlElement newQueryElement = _Document.CreateElement("Query");
            List<string> tagsNames = new List<string>()
            {
                "Day",
                "DayMonth",
                "Month",
                "Year",
                "Result"
            };

            for (int i = 0; i < tagsNames.Count; i++)
            {
                XmlElement child = _Document.CreateElement(tagsNames[i]);
                child.InnerText = listValue[i];
                newQueryElement.AppendChild(child);
            }
            GetRoot().AppendChild(newQueryElement);
            _Document.Save("Rabbinate.xml");
        }
    }
}
