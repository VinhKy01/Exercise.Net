using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class KhachHang
    {
        string tenkh, gioitinh, diachi, sdt;
        DateTime namsinh;
        #region properties
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime Namsinh { get => namsinh; set => namsinh = value; }
        #endregion
        public KhachHang(string tenkh, DateTime namsinh, string diachi, string sdt, string gioitinh)
        {
            this.Tenkh = tenkh;
            this.Namsinh = namsinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.Gioitinh = gioitinh;
        }
        public KhachHang(DataRow row)
        {
            this.Tenkh = row["tenkh"].ToString();
            this.Namsinh = (DateTime)row["namsinh"];
            this.Diachi = row["diachi"].ToString();
            this.Sdt = row["sdt"].ToString();
            this.Sdt = row["gioitinh"].ToString();
        }
    }
}
