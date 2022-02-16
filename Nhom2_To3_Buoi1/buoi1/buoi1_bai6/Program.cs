using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime timenow = System.DateTime.Now;
            Console.WriteLine("\t goi ham tao khong tham so");
            dateTime t1 = new dateTime();
            t1.Hien();
            Console.WriteLine();
            dateTime t2 = new dateTime(12, 10, 2014, 4, 56, 39);
            t2.Hien();
            Console.WriteLine();
            dateTime t3 = new dateTime(20, 05, 2014);
            t3.Hien();
            Console.WriteLine();
            dateTime t4 = new dateTime(t3);
            t4.Hien();
            Console.WriteLine();
            dateTime t5 = new dateTime(timenow);
            t5.Hien();
            Console.ReadKey();
        }
    }
}
