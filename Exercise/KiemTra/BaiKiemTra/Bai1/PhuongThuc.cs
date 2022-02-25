using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class PhuongThuc
    {
        public void Menu()
        {
            Console.WriteLine("\t\t--------------Lua Chon-------------");
            Console.WriteLine("\t\t-----1.Nhap vao 1 Sinh Vien-----");
            Console.WriteLine("\t\t-----2.Xuat danh sach Sinh Vien-----");
            Console.WriteLine("\t\t-----3.Sap xep danh sach Sinh Vien tang-----");
            Console.WriteLine("\t\t-----4.Sap xep danh sach Sinh Vien giam-----");
            Console.WriteLine("\t\t-----------------------------------------");
        }
        public void SapXepTang1(SinhVien[] sv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (SoSanh(sv[i].DiemToan, sv[j].DiemToan))
                    {
                        SinhVien tmp = new SinhVien();
                        tmp = sv[i];
                        sv[i] = sv[j];
                        sv[j] = tmp;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("\t\t-----DANH SACH SINH VIEN SAP XEP GIAM-----");
            for (int i = 0; i < n; i++)
            {
                sv[i].Xuat();
            }
        }

        public bool SoSanh(float t, float s)
        {
            if (t > s)
                return true;
            else
                return false;
        }

    }
}
