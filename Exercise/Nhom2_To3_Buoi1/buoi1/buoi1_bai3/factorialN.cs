using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai3
{
    class factorialN
    {
        //phuong thuc nhap 1 so lon hon 0 public
        public int NhapMotSo(int n)
        {
            int so;
            do
            {
                so = Convert.ToInt32(Console.ReadLine());
            } while (so > 0);
            return so;
        }
        //phuong thuc tinh giai thua n 
        public long TinhGiaiThuaN(int h)
        {
            long gt = 1;
            for (int i = 1; i <= h; i++)
            {
                gt = gt * i;
            }
            return gt;
        }
    }
}
