using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10._69.DTO
{
    public class NhanVien
    {
        string manv, holot, ten, phai, chucvu;
        DateTime ngaysinh;

        public string Manv { get => manv; set => manv = value; }
        public string Holot { get => holot; set => holot = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        public NhanVien(string manv, string holot, string ten, string phai, DateTime ngaysinh, string chucvu)
        {
            this.Manv = manv;
            this.Holot = holot;
            this.Ten = ten;
            this.Phai = phai;
            this.Ngaysinh = ngaysinh;
            this.Chucvu = chucvu;
        }

        public NhanVien(DataRow row)
        {
            this.Manv = row["manv"].ToString();
            this.Holot = row["holot"].ToString(); 
            this.Ten = row["ten"].ToString(); 
            this.Phai = row["phai"].ToString(); 
            this.Ngaysinh = (DateTime)row["ngaysinh"]; 
            this.Chucvu = row["tencv"].ToString(); 
        }
        
    }
}
