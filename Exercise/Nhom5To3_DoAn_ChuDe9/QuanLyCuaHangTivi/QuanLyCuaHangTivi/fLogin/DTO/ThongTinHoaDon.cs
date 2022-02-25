using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class ThongTinHoaDon
    {
        string masp;
        int iddonhang, sluong;

        public string Masp { get => masp; set => masp = value; }
        public int Iddonhang { get => Iddonhang1; set => Iddonhang1 = value; }
        public int Iddonhang1 { get => iddonhang; set => iddonhang = value; }
        public int Sluong { get => sluong; set => sluong = value; }

        public ThongTinHoaDon(string masp, int iddonhang, int sluong)
        {
            this.Masp = masp;
            this.Iddonhang = iddonhang;
            this.Sluong = sluong;
        }
        public ThongTinHoaDon(DataRow row)
        {
            this.Masp = row["masp"].ToString();
            this.Iddonhang = (int)row["iddonhang"];
            this.Sluong = (int)row["sluong"];
        }
    }
}
