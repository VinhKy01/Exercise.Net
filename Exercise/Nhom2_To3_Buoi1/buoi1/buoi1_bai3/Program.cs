using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            factorialN gtn = new factorialN();
            Console.Write("Nhập số n = "); n =
            gtn.NhapMotSo(n);
            Console.WriteLine("Giai thừa của {0} là {1}", n, gtn.TinhGiaiThuaN(n));
            Console.ReadLine();
        }
    }
}
