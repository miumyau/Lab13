using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal sealed class MultiBuilding : Building
    {
        private int count;
        public int Count
        {
            get { return count; }
            set {
                if (count < 0)
                {
                    Console.WriteLine("Значение меньше 0, ошибка!");
                }
                else
                    count = value; ; }
        }

        public MultiBuilding(string adresse, int lenth, int width, int height, int count) : base(adresse, lenth, width, height)
        {
            
            Count = count;
        }

        public new string Print()
        {
            string result = base.Print();
            result += $", этажность {count}";
            return result;
        }
    }
    
}

