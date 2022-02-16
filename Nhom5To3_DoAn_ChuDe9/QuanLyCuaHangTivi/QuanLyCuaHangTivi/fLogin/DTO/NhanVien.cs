using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class NhanVien
    {
        string msnv, hoten, gioitinh, diachi;
        DateTime namsinh;
        string sdt;
        int luongcoban;
        float hesoluong;
        float luong;
        #region properties
        public string Msnv { get => msnv; set => msnv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Namsinh { get => namsinh; set => namsinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Luongcoban { get => luongcoban; set => luongcoban = value; }
        public float Hesoluong { get => hesoluong; set => hesoluong = value; }
        public float Luong { get => luong; set => luong = value; }
        #endregion
        public NhanVien(string msnv, string hoten, string giotinh, string diachi, DateTime namsinh, string sdt, int luongcoban, float hesoluong, float luong)
        {
            this.Msnv = msnv;
            this.Hoten = hoten;
            this.Gioitinh = giotinh;
            this.Diachi = diachi;
            this.Namsinh = namsinh;
            this.Sdt = sdt;
            this.Luongcoban = luongcoban;
            this.Hesoluong = hesoluong;
            this.Luong = luong;
        }
        public NhanVien(DataRow row)
        {
            this.Msnv = row["msvn"].ToString();
            this.Hoten = row["hoten"].ToString();
            this.Gioitinh = row["gioitinh"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Namsinh = (DateTime)row["namsinh"];
            this.Sdt = row["sdt"].ToString();
            this.Luongcoban = (int)row["luongcoban"];
            this.Hesoluong = (float)Convert.ToDouble(row["hesoluong"].ToString());
            this.Luong = (float)Convert.ToDouble(row["luong"].ToString());
        }
    }
}
