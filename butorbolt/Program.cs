using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFurniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair szek = new Chair();
            Bed agy = new Bed();
            Table asztal = new Table();
            Furniture[] butorok = { szek, agy, asztal };

            foreach (Furniture butor in butorok)
            {
                butor.Print();
            }
        }
    }
}
