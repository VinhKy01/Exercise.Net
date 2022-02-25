using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class SinhVien
    {
        private string _ten;
        private float _diemToan;
        private float _diemVan;
        private float _diemTrungBinh;

        public string Ten { get => _ten; set => _ten = value; }
        public float DiemToan { get => _diemToan; set => _diemToan = value; }
        public float DiemVan { get => _diemVan; set => _diemVan = value; }
        public float DiemTrungBinh { get => _diemTrungBinh = (DiemToan + DiemVan) / 2; set => _diemTrungBinh = value; }

        public SinhVien()
        {
            Ten = "";
            DiemToan = DiemVan = 0;
        }

        public void Nhap()
        {
            Console.Write("\t\tNhap vao ten sinh vien: ");
            Ten = Console.ReadLine();
            Console.Write("\t\tNhap vao diem Toan: ");
            DiemToan = float.Parse(Console.ReadLine());
            Console.Write("\t\tNhap vao diem Van: ");
            DiemVan = float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("");
            Console.WriteLine($"\t\tTen: {Ten}");
            Console.WriteLine($"\t\tDiem Toan: {DiemToan}");
            Console.WriteLine($"\t\tDiem Van: {DiemVan}");
            Console.WriteLine($"\t\tDiem Trung Binh: {DiemTrungBinh}");
        }
    }
}
