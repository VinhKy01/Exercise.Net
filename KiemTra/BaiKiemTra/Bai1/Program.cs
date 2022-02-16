using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int soluong = 0, luachon;
            SinhVien[] sv = new SinhVien[200];
            PhuongThuc pt = new PhuongThuc();
            string nhapten;
            bool flag = false;
            do
            {
                Console.WriteLine("");
                pt.Menu();
                Console.Write("\t\t-----Nhap vao lua chon cua ban: ");
                luachon = Int32.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        {
                            sv[soluong] = new SinhVien();
                            sv[soluong].Nhap();
                            soluong++;
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("\t\t-----DANH SACH SINH VIEN-----");
                            for (int i = 0; i < soluong; i++)
                            {
                                sv[i].Xuat();
                            }
                            break;
                        }
                    case 3:
                        {
                            for (int i = 0; i < soluong; i++)
                            {
                                for (int j = 0; j < soluong - 1; j++)
                                {
                                    if (!pt.SoSanh(sv[i].DiemToan, sv[j].DiemToan))
                                    {
                                        SinhVien tmp = new SinhVien();
                                        tmp = sv[i];
                                        sv[i] = sv[j];
                                        sv[j] = tmp;
                                    }
                                }
                            }

                            Console.WriteLine("");
                            Console.WriteLine("\t\t-----DANH SACH SINH VIEN SAP XEP TANG-----");
                            for (int i = 0; i < soluong; i++)
                            {
                                sv[i].Xuat();
                            }
                            break;
                        }
                    case 4:
                        {
                            for (int i = 0; i < soluong; i++)
                            {
                                for (int j = 0; j < soluong - 1; j++)
                                {
                                    if (pt.SoSanh(sv[i].DiemToan, sv[j].DiemToan))
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
                            for (int i = 0; i < soluong; i++)
                            {
                                sv[i].Xuat();
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Write("\t\tNhap vao ten ban muon tim: ");
                            nhapten = Console.ReadLine();
                            for (int i = 0; i < soluong; i++)
                            {
                                if (sv[i].Ten.Equals(nhapten))
                                {
                                    sv[i].Xuat();
                                    flag = true;
                                }
                            }
                            if (flag == false)
                            {
                                Console.WriteLine("\t\tKhong tim thay ten sinh vien trong danh sach");
                            }
                            break;
                        }
                    case 6:
                        {
                            pt.SapXepTang1(sv, soluong);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\t\t---------Chuong trinh ket thuc---------");
                            break;
                        }
                }
            } while (luachon > 0 && luachon < 8);
        }
    }
}
