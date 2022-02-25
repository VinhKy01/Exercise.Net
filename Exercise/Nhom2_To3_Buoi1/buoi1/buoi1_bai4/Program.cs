using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            arrayN msn = new arrayN();
            int n;
            Console.Write("Nhập vào số phần tử mảng = "); n =
            msn.NhaSoDuong();
            int[] a = new int[n];
            msn.NhapMang(a);
            Console.WriteLine("Mảng vừa nhập ");
            msn.InMang(a);
            Console.WriteLine("\nSố lớn nhất trong mảng {0}", msn.findMax(a));
            Console.WriteLine("\nSố nhỏ nhất trong mảng {0}", msn.findMin(a));
            Console.WriteLine("\nTổng các phần tử trong mảng {0}", msn.sumArray(a));
            Console.WriteLine("\nMang sau khi sắp tă    ần ");
            msn.sortArray(a);
            Console.WriteLine("Mang sao khi sap xep la: ");
            msn.InMang(a);
            Console.ReadLine();
        }
    }
}
