using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai4
{
    class arrayN
    {
        //phuong thuc nhap mot so > 0
        public int NhaSoDuong()
        {
            int so;
            do
            {
                so = Convert.ToInt32(Console.ReadLine());
            } while (so < 0);
            return so;
        }
        //phuong thuc nhap mot so
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        //phuong thuc nhap mang
        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //phuong thuc in mang
        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(" {0}", a[i]);
        }
        //find min
        public int findMin(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }

        //find max
        public int findMax(int[] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        //Tính tổng các phần tử trong mảng
        public int sumArray(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }

        //hoan vi
        void swap(ref int a, ref int b)
        {
                            //a = 3, b = 5
            a = a - b;      // a = 3 - 5 = -2
            b = a + b;      //b = -2 + 5 = 3
            a = b - a;      // a = 3 - (-2) = 5
        }
        //sap xep tang dan
        public void sortArray(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] > a[j])
                        swap(ref a[i], ref a[j]);          
        }


    }
}

    
