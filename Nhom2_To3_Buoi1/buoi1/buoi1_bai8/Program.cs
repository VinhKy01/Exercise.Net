using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            tamGiac tg1 = new tamGiac();
            tamGiac tg2 = new tamGiac(3, 4, 5);
            tamGiac tg3 = new tamGiac();

            tg3.nhap();

            Console.WriteLine("\nTam giac 1: ");
            tg1.xuat();

            Console.WriteLine("\nTam giac 2: ");
            tg2.xuat();

            Console.WriteLine("\nTam giac 3: ");
            tg3.xuat();

            Console.ReadLine();
        }
    }
}
