using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            findMaxN sln = new findMaxN();
            int n;
            Console.Write("Nhập n = "); n =
            sln.NhapMotSo();
            Console.WriteLine("Số lớn nhất trong {0} vừa nhập là {1} ", n, sln.TimMax(n));
            Console.ReadLine();
        }
    }
}
