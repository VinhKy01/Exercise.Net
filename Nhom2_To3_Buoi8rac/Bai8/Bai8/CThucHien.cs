using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class CThucHien
    {
        //----------------------HINH VUONG-----------------------
        public float DienTichHinhVuong(float canh)
        {
            float dientich = 0;
            dientich = canh * canh;
            return dientich;
        }

        public int ChuViHinhVuong(int canh)
        {
            int chuvi = 0;
            chuvi = canh * 4;
            return chuvi;
        }

        //----------------------HINH CHU NHAT-----------------------

        public float DienTichHinhChuNhat(float dai, float rong)
        {
            float dientich = 0;
            dientich = dai * rong;
            return dientich;
        }

        public int ChuViHinhChuNhat(int dai, int rong)
        {
            int chuvi = 0;
            chuvi = (dai + rong) * 2;
            return chuvi;
        }

        //----------------------HINH TRON-----------------------

        public double DienTichHinhTron(double bankinh)
        {
            double dientich = 0;
            dientich = Math.PI * (bankinh * bankinh);
            return dientich;
        }

        public double ChuViHinhTron(double bankinh)
        {
            double chuvi = 0;
            chuvi = 2 * bankinh * Math.PI;
            return chuvi;
        }
    }
}
