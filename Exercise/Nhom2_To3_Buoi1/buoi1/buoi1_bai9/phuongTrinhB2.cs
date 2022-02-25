using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai9
{
    class phuongTrinhB2
    {
        //thuoc tinh
        double a, b, c, x1, x2;

        //constructor
        public phuongTrinhB2()
        {
            a = b = c = x1 = x2 = 0;
        }
        public phuongTrinhB2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            tinhNghiem();
        }

        //properties
        public double hsA
        {
            get { return a; }
            set { a = value; }
        }
        public double hsB
        {
            get { return b; }
            set { b = value; }
        }
        public double hsC
        {
            get { return c; }
            set { c = value; }
        }
        public double X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public double X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        //solve
        public int tinhNghiem()
        {
            double Delta = hsB * hsB - 4 * hsA * hsC;
            if (Delta < 0)
                return -1;
            else
            {
                X1 = (-hsB + Math.Sqrt(Delta)) / (2 * hsA);
                X2 = (-hsB - Math.Sqrt(Delta)) / (2 * hsA);
                if (Delta == 0)
                    return 0;
                else
                    return 1;
            }

        }

        //nhap xuat
        public void nhap()
        {
            Console.WriteLine("\nNhap cac he so cua ptb2 y = ax2 + bx + c");
            Console.Write("\ta = ");
            hsA = double.Parse(Console.ReadLine());
            Console.Write("\tb = ");
            hsB = double.Parse(Console.ReadLine());
            Console.Write("\tc = ");
            hsC = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            int temp = tinhNghiem();
            if (temp == -1)
                Console.WriteLine("Phuong trinh y = {0}x2 + {1}x + {2} vo nghiem!", hsA, hsB, hsC);
            else if (temp == 0)
                Console.WriteLine("Phuong trinh y = {0}x2 + {1}x + {2} co nghiem kep x1 = x2 = {3}", hsA, hsB, hsC, Math.Round(X1, 2));
            else
                Console.WriteLine("Phuong trinh y = {0}x2 + {1}x + {2} co 2 nghiem: \nx1 = {3} \nx2 = {4}", hsA, hsB, hsC, Math.Round(X1, 2), Math.Round(X2, 2));
        }

    }
}
