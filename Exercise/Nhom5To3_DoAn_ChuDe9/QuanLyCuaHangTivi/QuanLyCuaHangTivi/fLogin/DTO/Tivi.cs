using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class Tivi
    {
        string mstivi, tenhang, tinhtrang;
        int gia, baohanh, kichthuoc, soluong;
        #region properties
        public string Mstivi { get => mstivi; set => mstivi = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Baohanh { get => baohanh; set => baohanh = value; }
        public int Kichthuoc { get => kichthuoc; set => kichthuoc = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        #endregion
        public Tivi(string mstivi, string tenhang, int kichthuoc, int gia, string tinhtrang, int baohanh, int soluong)
        {
            this.Mstivi = mstivi;
            this.Tenhang = Tenhang;
            this.Kichthuoc = Kichthuoc;
            this.Gia = gia;
            this.Tinhtrang = tinhtrang;
            this.Baohanh = baohanh;
            this.Soluong = soluong;
        }
        public Tivi(DataRow row)
        {
            this.Mstivi = row["mstivi"].ToString();
            this.Tenhang = row["tenhang"].ToString();
            this.Kichthuoc = (int)Convert.ToDouble(row["kichthuoc"]);
            this.Gia = (int)Convert.ToDouble(row["gia"]);
            this.Tinhtrang = row["tinhtrang"].ToString();
            this.Baohanh = (int)Convert.ToDouble(row["baohanh"]);
            this.Soluong = (int)Convert.ToDouble(row["soluong"]);
        }

    }
}
