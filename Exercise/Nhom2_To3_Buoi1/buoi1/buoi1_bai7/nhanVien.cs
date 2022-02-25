using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai7
{
    class nhanVien
    {
        //thuoc tinh
        private String id, name, yearOfBirth;
        private double heSoLuong, luongCoBan;

        //phuong thuc khoi tao
        public nhanVien()
        {
            id = name = yearOfBirth = "";
            heSoLuong = luongCoBan = 0;
        }

        public nhanVien(String id, String name, String yearOfBirth, double heSoLuong, double luongCoBan)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.heSoLuong = heSoLuong;
            this.luongCoBan = luongCoBan;
        }

        //properties
        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String YearOfBirth
        {
            get { return yearOfBirth; }
            set { yearOfBirth = value; }
        }

        public double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }

        public double LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }

        //nhap xuat du lieu
        public void nhap()
        {
            Console.WriteLine("\nNhap thong tin nhan vien: ");
            Console.Write("ID: ");
            Id = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Year Of Birth: ");
            YearOfBirth = Console.ReadLine();
            Console.Write("He so luong: ");
            HeSoLuong = Double.Parse(Console.ReadLine());
            Console.Write("Luong co ban: ");
            LuongCoBan = Double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-5}{3,-5}{4,-10}{5,-10}", Id, Name, YearOfBirth, HeSoLuong, LuongCoBan, thuNhap());
        }

        //tinh thu nhap nv
        public double thuNhap()
        {
            return LuongCoBan * HeSoLuong;
        }
    }
}
