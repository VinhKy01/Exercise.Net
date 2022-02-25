using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    DTH195150 - NGUYỄN VĨNH KỲ - DH20TH1 
*/

namespace DTH195150_NguyenVinhKy
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            GiaiPTB1 ptb1 = new GiaiPTB1();
            Console.Write("\t== PHUONG TRINH BAC 1: ax + b = 0 == \n");
            Console.Write("\n\tNhap vao gia tri cua a: ");
            a = ptb1.Nhap();

            Console.Write("\n\tNhap vao gia tri cua b: ");
            b = ptb1.Nhap();
            Console.Write("\n");

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.Write("\tPHUONG TRINH " + a + "x + " + b + " = 0 CO VO SO NGHIEM");
                    Console.Write("\n");
                }
                else
                    Console.Write("\tPHUONG TRINH " + a + "x + " + b + " = 0 VO NGHIEM");
                    Console.Write("\n");
            }
            else
            {
                if(b==0)
                {
                    Console.Write("\tPHUONG TRINH " + a + "x + " + b + " = 0 CO NGHIEM DUY NHAT\n\t=> X = "+ptb1.NB1(a,b));
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("\tPHUONG TRINH BAC 1 : " + a + "x + " + b + " = 0 \n\t=> X = "+ptb1.NB1(a, b));
                    Console.Write("\n");
                }
                
            }

            
        }

    }
}
