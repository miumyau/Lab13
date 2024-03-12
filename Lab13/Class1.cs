using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Building
    {
        private string adresse;
        private int lenth;
        private int width;
        private int height;

        public string Adresse 
        {
             get 
            {
              return adresse;
            }
             set
            {
                adresse = value;
            }
        }

        public int Lenth
        {
            get
            {
                return lenth;
            }
            set
            {
                if (lenth < 0)
                {
                    Console.WriteLine("Значение меньше 0, ошибка!");
                }
                else
                    lenth = value;
            }

          
        }
        public int Width
        {
            get 
            {
                return width;
            }
            set
            {
                if (width < 0)
                {
                    Console.WriteLine("Значение меньше 0, ошибка!");
                }
                else
                    width = value;
            }

        }

        public int Height
        {
            get
            {
                return height;
            }
            set 
            {
                if (height < 0)
                {
                    Console.WriteLine("Значение меньше 0, ошибка!");
                }
                else
                    height = value; 
            }
        }

        public Building (string adresse, int lenth, int width, int height)
        {
            Adresse = adresse;
            Lenth = lenth;
            Width = width;
            Height = height;
        }

        public string Print ()
        {
            return $"Здание находится по адресу {adresse}, имеет длину {lenth}, высоту {height}, ширину {width}";
        }

    }
}
