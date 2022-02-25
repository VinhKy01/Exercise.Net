using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai8
{
    class tamGiac
    {
        //thuoc tinh
        private int canh1, canh2, canh3, chuVi, loaiTG;
        private float dienTich;

        //constructor
        public tamGiac()
        {
            canh1 = 2;
            canh2 = 3;
            canh3 = -5;
        }

        public tamGiac(int a, int b, int c)
        {
            Canh1 = a;
            Canh2 = b;
            Canh3 = c;
        }

        //properties
        public int Canh1
        {
            get { return canh1; }
            set { canh1 = value; }
        }
        public int Canh2
        {
            get { return canh2; }
            set { canh2 = value; }
        }
        public int Canh3
        {
            get { return canh3; }
            set { canh3 = value; }
        }
        public int ChuVi
        {
            get { return tinhChuVi(); }
            set { chuVi = value; }
        }
        public int LoaiTG
        {
            get { return loaiTG; }
            set { loaiTG = value; }
        }
        public float DienTich
        {
            get { return tinhDienTich(); }
            set { dienTich = value; }
        }

        //chu vi
        public int tinhChuVi()
        {
            return ChuVi = Canh1 + Canh2 + Canh3;
        }

        //dien tich
        public float tinhDienTich()
        {
            float p = (Canh1 + Canh2 + Canh3) / 2;
            return DienTich = (float)Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
        }

        //phan loai tam giac
        public int phanLoai()
        {
            if (Canh1 + Canh2 > Canh3 && Canh1 + Canh3 > Canh2 && Canh2 + Canh3 > Canh1)
            {
                Console.Write("Day la tam giac ");
                if (Canh1 == Canh2 && Canh2 == Canh3)
                {
                    Console.Write(" deu");
                    return 1;
                }
                else if ((Canh1 == Canh2 || Canh2 == Canh3 || Canh3 == Canh1) && (Canh1 * Canh1 + Canh2 * Canh2 == Canh3 * Canh3 || Canh1 * Canh1 + Canh3 * Canh3 == Canh2 * Canh2 || Canh2 * Canh2 + Canh3 * Canh3 == Canh1 * Canh1))
                {
                    Console.Write(" vuong can");
                    return 2;
                }
                else if (Canh1 == Canh2 || Canh2 == Canh3 || Canh3 == Canh1)
                {
                    Console.Write(" can");
                    return 3;
                }
                else if (Canh1 * Canh1 + Canh2 * Canh2 == Canh3 * Canh3 || Canh1 * Canh1 + Canh3 * Canh3 == Canh2 * Canh2 || Canh2 * Canh2 + Canh3 * Canh3 == Canh1 * Canh1)
                {
                    Console.Write(" vuong");
                    return 4;
                }
                else
                {
                    Console.Write(" thuong");
                    return 5;
                }
            }
            else
            {
                Console.WriteLine("Day khong phai tam giac");
                return 0;
            }
        }

        //nhap tam giac
        public void nhap()
        {
            int temp;
            Console.WriteLine("Nhap thong tin tam giac: ");
            Console.Write("Canh 1: ");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine(" \t !!! Do dai canh > 0");
                Console.Write(" \t -Nhap lai canh 1: ");
                temp = Convert.ToInt32(Console.ReadLine());
            }
            Canh1 = temp;

            Console.Write("Canh 2: ");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine(" \t !!! Do dai canh > 0");
                Console.Write(" \t -Nhap lai canh 2: ");
                temp = Convert.ToInt32(Console.ReadLine());
            }
            Canh2 = temp;

            Console.Write("Canh 3: ");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine(" \t !!! Do dai canh > 0");
                Console.Write(" \t -Nhap lai canh 3: ");
                temp = Convert.ToInt32(Console.ReadLine());
            }
            Canh3 = temp;
        }

        //xuat
        public void xuat()
        {
            Console.WriteLine("Thong tin tam giac: \nCanh 1 = {0} \nCanh 2 = {1} \nCanh 3 = {2}", Canh1, Canh2, Canh3);
            if (phanLoai() == 0)
                return;
            Console.WriteLine("\nChu vi: {0} \nDien tich: {1}", ChuVi, DienTich);
        }
    }
}
