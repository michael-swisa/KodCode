using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shabat
{
    internal class Pillar
    {
        public Pillar() { }

        private int _Heigth;
        public int Heigth
        {
            get { return _Heigth; }
            set { _Heigth = value; }
        }
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        private string _Location;
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public string GetStatus()
        {
            string final = "";
            switch (Location)
            {
                case "RH":
                    final = "דינו כרשות היחיד";
                    break;

                case "RHR":
                    if (Heigth <= 3 || Heigth >= 9)
                    {
                        final = "דינו רשות הרבים";
                        break;
                    }
                    else if (Heigth > 3 && Heigth < 9)
                    {
                        if (Width >= 4)
                        {
                            final = "דינו כרמלית";
                            break;
                        }
                        else if (Width < 4)
                        {
                            final = "דינו מקום פטור";
                            break;
                        }
                        else
                            ;
                        final = "ERROR";
                    }
                    else if (Heigth >= 10 && Width >= 4)
                    {
                        final = "דינו רשות היחיד";
                        break;
                    }
                    else if (Width < 4 && Heigth > 3)
                    {
                        final = "דינו מקום פטור";
                        break;
                    }
                    else
                        ;
                    final = "ERROR";

                    return final;

                case "CAR":
                    if (Heigth < 10 && Width >= 4)
                    {
                        final = "דינו כרמלית לכולי עלמא";
                        break;
                    }
                    else if (Heigth >= 10 && Width >= 4)
                    {
                        final = "דינו רשות היחיד";
                        break;
                    }
                    else if (Heigth >= 10 && Width < 4)
                    {
                        final = "לפי הטור דינו כרמלית לפי רש'י דינו פטור";
                        break;
                    }
                    else
                        ;
                    final = "ERROR";
                    return final;

                default:
                    return final;
            }
            return final;
        }
    }
}
