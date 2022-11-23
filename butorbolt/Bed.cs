using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    internal class Bed : Furniture
    {
        const int basePrice = 25000;
        const int id = 1;
        protected int hossz = 200;
        protected int szelesseg = 160;
        protected double ar;
        public double Ar
        {
            get { return ar; }
            set
            {
                ar = basePrice * 2.4;
            }
        }
        public override void Print()
        {
            Ar = ar;
            Console.Write($"Az ágy ára {ar} |");
            Console.Write($" Az ágy azonositoja {id} |");
            Console.Write($" Az ágy hossza {hossz} |");
            Console.WriteLine($" Az ágy szélessége {szelesseg} |");
        }
    }
}
