using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            //khoi tao rong
            nhanVien nv1 = new nhanVien();

            //khoi tao co tham so
            nhanVien nv2 = new nhanVien("002", "Nguyen Van A", "2001", 1.6, 10000000);

            //nguoi dung nhap
            nhanVien nv3 = new nhanVien();
            nv3.nhap();

            //xuat thong tin cac nhan vien
            Console.WriteLine("\n{0,-10}{1,-20}{2,-5}{3,-5}{4,-10}{5,-10}", "ID", "Name", "YOB", "HSL", "LCB", "Thu nhap");
            nv1.xuat();
            nv2.xuat();
            nv3.xuat();

            Console.ReadLine();
        }
    }
}
