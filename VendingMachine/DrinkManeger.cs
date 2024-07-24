using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace VendingMachine
{
    internal class DrinkManeger
    {
        private XmlDocument _Document;

        public DrinkManeger(XmlDocument Doc)
        {
            _Document = Doc;
        }

        public List<List<string>> GetDrinksData()
        {
            List<List<string>> AllDrinks = new List<List<string>>();

            XmlNodeList drinksNodes = _Document.SelectNodes("/drinks/drink");
            if (drinksNodes != null)
            {
                foreach (XmlNode drink in drinksNodes)
                {
                    List<string> oneDrink = new List<string>();
                    if (drink.ChildNodes != null)
                    {
                        foreach (XmlNode item in drink.ChildNodes)
                        {
                            oneDrink.Add(item.InnerText);
                        }
                    }

                    AllDrinks.Add(oneDrink);
                }

                Console.WriteLine(AllDrinks);
            }
            return AllDrinks;
        }

        private XmlNode GetRoot()
        {
            return _Document.GetElementsByTagName("drinks")[0];
        }

        public void AddDrink(List<string> newDrink)
        {
            XmlElement newDrinkElement = _Document.CreateElement("drink");
            List<string> tagsNames = new List<string>()
            {
                "name",
                "soger",
                "coffee",
                "milk",
                "cacao",
                "price"
            };

            for (int i = 0; i < tagsNames.Count; i++)
            {
                XmlElement child = _Document.CreateElement(tagsNames[i]);
                child.InnerText = newDrink[i];
                newDrinkElement.AppendChild(child);
            }

            GetRoot().AppendChild(newDrinkElement);
            _Document.Save("Drinks.xml");
        }

        public void Save()
        {
            MainProject.Save(_Document);
        }

        public void UpdateDrink(List<string> drinks)
        {
            XmlNodeList drinksList = _Document.GetElementsByTagName("name");
            if (drinksList == null)
                return;
            foreach (XmlNode drink in drinksList)
            {
                if (drink.InnerText == drinks[0])
                {
                    int i = 0;
                    foreach (XmlNode child in drink.ParentNode)
                    {
                        child.InnerText = drinks[i];
                        i++;
                    }
                }
            }
        }

        public void DelDrink(string drinks)
        {
            XmlNodeList drinksList = _Document.SelectNodes("/drinks/drink");

            foreach (XmlNode drink in drinksList)
            {
                XmlNodeList children = drink.ChildNodes;
                foreach (XmlNode child in children)
                {
                    if (child.Name == "name" && child.InnerText == drinks)
                    {
                        _Document.DocumentElement.RemoveChild(drink);
                        return;
                    }
                }
            }
        }
    }
}
