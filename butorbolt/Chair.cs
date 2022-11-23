using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    internal class Chair : Furniture
    {
        const int basePrice = 25000;
        const int id = 0;
        protected double ar;
        protected int labszam = 4;
        public double Ar
        {
            get { return ar; }
            set {
                ar = basePrice * 1.2;
            }
        }
        public override void Print()
        {
            Ar = ar;
            Console.Write($"A szék ára {ar} |");
            Console.Write($" A szék azonositoja {id} |");
            Console.WriteLine($" A szék labainak szama {labszam} |");
        }
    }
}
