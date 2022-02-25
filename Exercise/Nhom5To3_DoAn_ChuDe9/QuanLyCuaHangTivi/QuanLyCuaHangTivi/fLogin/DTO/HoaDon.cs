using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class HoaDon
    {
        int madonhang, tongtien, khuyenmai;
        DateTime ngayban;
        string tenkh;

        #region properties
        public int Madonhang { get => madonhang; set => madonhang = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public int Khuyenmai { get => khuyenmai; set => khuyenmai = value; }
        public DateTime Ngayban { get => ngayban; set => ngayban = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        #endregion

        public HoaDon(int madonhang, string tenkh, DateTime ngayban, int khuyenmai, int tongtien)
        {
            this.Madonhang = madonhang;
            this.Tenkh = tenkh;
            this.Ngayban = ngayban;
            this.Khuyenmai = khuyenmai;
            this.Tongtien = tongtien;
        }
        public HoaDon(DataRow row)
        {
            this.Madonhang = (int)row["madonhang"];
            this.Tenkh = row["tenkh"].ToString();
            this.Ngayban = (DateTime)row["ngayban"];
            this.Khuyenmai = (int)row["khuyenmai"];
            this.Tongtien = (int)row["tongtien"];
        }
    }
}
