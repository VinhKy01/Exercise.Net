using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTH195150_NguyenVinhKy
{
    class GiaiPTB1
    {
        public int Nhap()
        {
            int Scanner;
            Scanner = Convert.ToInt32(Console.ReadLine());
            return Scanner;
        }

        public float NB1(float a, float b)
        {
            float kq;
            kq = -b / a;
            return kq;
        }
    }
}
