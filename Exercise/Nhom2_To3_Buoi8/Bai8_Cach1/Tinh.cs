using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_Cach1
{
    public class Tinh
    {
        float chuvi, dientich;

        public float Chuvi { get => chuvi; set => chuvi = value; }
        public float Dientich { get => dientich; set => dientich = value; }

        //hinh tron
        public Tinh(int bk) {
            Chuvi = (float)Math.PI * bk * 2;
            Dientich = (float)Math.PI * bk * bk;
        }

        //hinh vuong
        public Tinh(int canh, bool t)
        {
            Chuvi = (float)canh*4;
            Dientich = (float)canh*canh;
        }

        //hinh chu nhat
        public Tinh(int dai, int rong)
        {
            Chuvi = (float)2 * (dai + rong);
            Dientich = (float)dai * rong;
        }
    }
}
