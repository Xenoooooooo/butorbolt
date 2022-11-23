using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    internal class Table : Furniture
    {
        const int basePrice = 25000;
        const int id = 2;
        protected int magassag = 75;
        protected double ar;
        public double Ar
        {
            get { return ar; }
            set
            {
                ar = basePrice * 0.3;
            }
        }
        public override void Print()
        {
            Ar = ar;
            Console.Write($"Az asztal ára {ar} |");
            Console.Write($" Az asztal azonositoja {id} |");
            Console.WriteLine($" Az asztal magassaga {magassag} |");
        }
    }
}
